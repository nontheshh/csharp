
namespace SomeWebApplication.Models
{
    public class BookRating
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string UserId { get; set; }
        public int FivePointRatingId { get; set; }

        public FivePointRating FivePointRating { get; set; }
        public Book Book { get; set; }
        public ApplicationUser User { get; set; }
    }
}