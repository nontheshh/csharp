using Microsoft.AspNet.Identity;
using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using SomeWebApplication.Models;
using SomeWebApplication.Models.ViewModels;

namespace SomeWebApplication.Controllers
{
    public class AuthorController : Controller
    {

        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        // GET: Author
        public ActionResult Index(string authorId)
        {
            if (String.IsNullOrEmpty(authorId))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var user = _context.Users
                .Include(u => u.Books.Select(b => b.Genres))
                .SingleOrDefault(u => u.Id == authorId);

            if (user == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }

            return View(user);
        }

        [HttpGet]
        public ActionResult GetAvatar(string id)
        {
            if (String.IsNullOrEmpty(id))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var user = _context.Users.Find(id);

            if (user == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }

            if (user.AvatarBytes == null)
            {
                string path = System.IO.Path.Combine(Server.MapPath("~/"), "noavatar.png");
                return File(System.IO.File.ReadAllBytes(path), "image");
            }

            return File(_context.Users.Find(id).AvatarBytes, "image");
        }

        [HttpGet]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult SetAvatar(string id)
        {
            var user = _context.Users.Find(id);
            return View(user);
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult SetAvatar(AuthorDetailsViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = _context.Users.Find(User.Identity.GetUserId());

            if (user == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }

            user.AvatarBytes = PostedFileHelper.GetBytesOfHttpPostedFile(model.AvatarFile);

            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();

            return View(user.Id);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && _context != null)
            {
                _context.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}