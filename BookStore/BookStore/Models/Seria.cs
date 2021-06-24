
namespace BookStore.Models
{
    public class Seria
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Part { get; set; }
        public override string ToString()
        {
            return $"Id: {Id}; Name: {Name}";
        }
    }
}
