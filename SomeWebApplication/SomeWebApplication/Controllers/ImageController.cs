using System.Web.Mvc;
using SomeWebApplication.Models;

namespace SomeWebApplication.Controllers
{
    public class ImageController : Controller
    {

        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        // GET: Image
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetImage(int id)
        {
            return File(_context.Books.Find(id).CoverBytes, "image");
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