
namespace SomeWebApplication.Models
{
    public class CommentRating
    {
        public int Id { get; set; }
        public int CommentId { get; set; }
        public string UserId { get; set; }
        public int TwoPointRatingId { get; set; }

        public TwoPointRating TwoPointRating { get; set; }
        public Comment Comment { get; set; }
        public ApplicationUser User { get; set; }
    }
}