
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SomeWebApplication.Models
{
    public class Comment
    {
        public Comment()
        {
            CommentRatings = new List<CommentRating>();
        }

        public int Id { get; set; }
        public string UserId { get; set; }
        public int BookId { get; set; }
        public string Text { get; set; }
        public DateTime TimeStamp { get; set; }

        [NotMapped]
        public int SumRating { get; set; }

        public IList<CommentRating> CommentRatings { get; set; }
        public ApplicationUser User { get; set; }
        public Book Book { get; set; }
    }
}