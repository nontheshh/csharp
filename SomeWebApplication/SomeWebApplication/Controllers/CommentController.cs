using System;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
using Newtonsoft.Json;
using SomeWebApplication.Models;

namespace SomeWebApplication.Controllers
{
    public class CommentController : Controller
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        private int _pageSize = 2;

        // GET: Comment
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetCommentsPerPageJson(int bookId, int page)
        {
            var allComments = _context.Comments
                .Include(c => c.User)
                .Include(c => c.CommentRatings.Select(cr => cr.TwoPointRating))
                .Where(c => c.BookId == bookId)
                .ToList();

            string qtPages = Math.Ceiling((double)allComments.Count / _pageSize).ToString();

            var comments = allComments
                .OrderBy(c => c.Id)
                .Skip((page - 1) * _pageSize)
                .Take(_pageSize);

            foreach (var c in comments)
            {
                foreach (var cr in c.CommentRatings)
                    c.SumRating += (int)cr.TwoPointRating.Rating;
            }

            string res = JsonConvert.SerializeObject(
                comments,
                Formatting.None,
                new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });

            var result = new JsonResult
            {
                Data = new
                {
                    data = res,
                    qtPages,
                    pagesSize = _pageSize
                },
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };

            return result;
        }

        public int GetCommentRatingJson(int commentId)
        {
            var commentRatings = _context.CommentRatings
               .Include(cr => cr.TwoPointRating)
               .Where(cr => cr.CommentId == commentId)
               .ToList();

            return commentRatings.Sum(cr => (int)cr.TwoPointRating.Rating);
        }

        public void RateComment(int commentId, string ratingTypeString)
        {
            var userId = User.Identity.GetUserId();
            var rating = (TwoPointRatingEnum)Enum.Parse(typeof(TwoPointRatingEnum), ratingTypeString);

            var commentRating = _context.CommentRatings
              .Where(cr => cr.CommentId == commentId)
            .SingleOrDefault(cr => cr.UserId == userId);

            if (commentRating != null) return;

            var q = new TwoPointRating { Rating = rating };
            var rate = new CommentRating { CommentId = commentId, TwoPointRating = q, UserId = User.Identity.GetUserId() };

            _context.CommentRatings.Add(rate);
            _context.SaveChanges();
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