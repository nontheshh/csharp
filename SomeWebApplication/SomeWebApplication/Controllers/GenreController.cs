using System.Linq;
using System.Net;
using System.Web.Mvc;
using System.Data.Entity;
using PagedList;
using SomeWebApplication.Models;

namespace SomeWebApplication.Controllers
{
    public class GenreController : Controller
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        private int _pageSize = 2;

        // GET: Genre
        public ActionResult Index(int? genreId, int? page)
        {
            if (genreId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            int pageNumber = (page ?? 1);

            ViewBag.GenreName = _context.Genres.Where(g => g.Id == genreId).FirstOrDefault().Name;
            ViewBag.GenreId = _context.Genres.Where(g => g.Id == genreId).FirstOrDefault().Id.ToString();
            var books = from b in _context.Books
                            .Include(b => b.Genres)
                            .Include(b => b.ApplicationUsers)
                        where b.Genres.FirstOrDefault(g => g.Id == genreId) != null
                        orderby b.Id
                        select b;

            return View(books.ToPagedList(pageNumber, _pageSize));
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