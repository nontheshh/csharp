using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PageCount { get; set; }
        public int PartNumber { get; set; }
        public DateTime PublishDate { get; set; }
        public double PrimeCost { get; set; }
        public double SaleCost { get; set; }
        public int Part { get; set; }
        public ICollection<Author> Author { get; set; }
        public PublishingHouse PublishingHouse { get; set; }
        public Theme Theme { get; set; }
        public Seria Seria { get; set; }
        public override string ToString()
        {
            return $"Id: {Id}; Title: {Title}";
        }
        public Book()
        {
            Author = new List<Author>();
        }
    }
}
