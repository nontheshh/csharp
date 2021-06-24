
namespace BookStore.Models
{
    public class StorageBook
    {
        public Book Book { get; set; }
        public int Quantity { get; set; }
        public override string ToString()
        {
            return $"Id: {Book.Id}; Title: {Book.Title}; Quantity: {Quantity}";
        }
    }
}
