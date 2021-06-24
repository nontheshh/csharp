using System;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
using SomeWebApplication.Models;
using SomeWebApplication.Models.ViewModels;

namespace SomeWebApplication.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        // GET: Book
        public ActionResult Index(int? bookId)
        {
            if (bookId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var book = _context.Books
                .Include(b => b.Genres)
                .Include(b => b.ApplicationUsers)
                .SingleOrDefault(b => b.Id == bookId);

            if (book == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }

            return View(book);
        }

        [Authorize]
        [HttpGet]
        public ActionResult CreateBook()
        {
            var model = new CreateBookViewModel
            {
                Genres = new MultiSelectList(_context.Genres, "Id", "Name")
            };

            return View(model);
        }

        [Authorize]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult CreateBook(CreateBookViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Genres = new MultiSelectList(_context.Genres, "Id", "Name");
                return View(model);
            }

            Book book = new Book
            {
                Title = model.Title,
                Annotation = model.Annotation,
                Text = PostedFileHelper.GetFileContentFromBytes(PostedFileHelper.GetBytesOfHttpPostedFile(model.TextFile)),
                CoverBytes = PostedFileHelper.GetBytesOfHttpPostedFile(model.CoverFile),
                Status = "Finished",
                TimeStamp = DateTime.Now
            };

            string userId = User.Identity.GetUserId();
            var user = _context.Users.Find(userId);

            if (!String.IsNullOrEmpty(model.Authors))
            {
                foreach (var au in model.Authors.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    var couser = _context.Users.SingleOrDefault(u => u.UserName == au);
                    if (couser == null) continue;
                    book.ApplicationUsers.Add(couser);
                }
            }

            book.ApplicationUsers.Add(user);

            foreach (var id in model.GenreIds)
            {
                var genre = _context.Genres.Find(id);
                book.Genres.Add(genre);
            }

            _context.Books.Add(book);
            _context.SaveChanges();

            return View("CreateBookSuccess", book);
        }

        public int GetBookRatingJson(int bookId)
        {
            var bookRating = _context.BookRatings
               .Include(cr => cr.FivePointRating)
               .Where(cr => cr.BookId == bookId)
               .ToList();

            return bookRating.Sum(cr => (int)cr.FivePointRating.Rating);
        }

        public void RateBook(int bookId, string ratingTypeString)
        {
            var userId = User.Identity.GetUserId();
            var rating = (FivePointRatingEnum)Enum.Parse(typeof(FivePointRatingEnum), ratingTypeString);


            var q = new FivePointRating { Rating = rating };
            var rate = new BookRating { BookId = bookId, FivePointRating = q, UserId = userId };

            _context.BookRatings.Add(rate);
            _context.SaveChanges();
        }


        [HttpGet]
        public ActionResult LeaveComment()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult LeaveComment(CommentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var comment = new Comment
            {
                BookId = model.BookId,
                UserId = User.Identity.GetUserId(),
                Text = model.Text,
                TimeStamp = DateTime.Now
            };

            _context.Comments.Add(comment);
            _context.SaveChanges();

            return RedirectToAction("Index", new { bookId = model.BookId });
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