using System;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using SomeWebApplication.Models;

namespace SomeWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        [HttpGet]
        public ActionResult Index()
        {
            if (_context.Genres.Count() == 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    _context.Genres.Add(new Genre { Name = "Genre " + i.ToString() });
                }
                _context.SaveChanges();
            }
            var genres = _context.Genres;

            return View(genres.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
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