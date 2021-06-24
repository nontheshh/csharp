using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;
using PagedList;
using SomeWebApplication.Models;

namespace SomeWebApplication.Controllers
{
    public class SearchController : Controller
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        private int _pageSize = 2;


        // GET: Search
        public ActionResult Index(SearchBookViewModel model, int? page)
        {
            if (String.IsNullOrEmpty(model.SearchGenreString))
            {
                model = new SearchBookViewModel
                {
                    GenreNames = GetGenreNamesWithDefault()
                };
                return View(model);
            }
            int pageNumber = page ?? 1;

            if (model.SearchGenreString == "Any" &&
                String.IsNullOrEmpty(model.SearchAuthorString) &&
                String.IsNullOrEmpty(model.SearchTitleString))
            {
                model.GenreNames = GetGenreNamesWithDefault();
                return View(model);
            }

            var books = from b in _context.Books
                        .Include(b => b.Genres)
                        .Include(b => b.ApplicationUsers)
                        select b;

            if (!String.IsNullOrEmpty(model.SearchTitleString))
            {
                books = books.Where(b => b.Title.Contains(model.SearchTitleString));
            }
            if (model.SearchGenreString != "Any" && !String.IsNullOrEmpty(model.SearchGenreString))
            {
                books = books.Where(b => b.Genres.Select(g => g.Name).Contains(model.SearchGenreString));
            }
            if (!String.IsNullOrEmpty(model.SearchAuthorString))
            {
                books = books.Where(b => b.ApplicationUsers.Select(bb => bb.UserName).Contains(model.SearchAuthorString));
            }

            var list = books.ToList();
            if (list.Count != 0)
            {
                books = books.OrderBy(b => b.Id);
                model.FoundBooks = list.ToPagedList(pageNumber, _pageSize);
            }

            model.GenreNames = GetGenreNamesWithDefault();
            return View(model);
        }

        private List<string> GetGenreNamesWithDefault()
        {
            var genreNames = _context.Genres.Select(g => g.Name).ToList();
            genreNames.Insert(0, "Any");
            return genreNames;
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