public enum FivePointRatingEnum { VeryBad = 1, Bad, NotBad, Good, VeryGood }
public enum TwoPointRatingEnum { bla = -1, blabla = 1 }

namespace SomeWebApplication.Models
{
    public class FivePointRating
    {
        public int Id { get; set; }
        public FivePointRatingEnum Rating { get; set; }
    }

    public class TwoPointRating
    {
        public int Id { get; set; }
        public TwoPointRatingEnum Rating { get; set; }
    }
}