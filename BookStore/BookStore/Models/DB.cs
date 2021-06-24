using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class DB
    {
        public ICollection<Book> BookSet { get; set; }
        public ICollection<Author> AuthorSet { get; set; }
        public ICollection<PublishingHouse> PublishingHouseSet { get; set; }
        public ICollection<Theme> ThemeSet { get; set; }
        public ICollection<Seria> SeriaSet { get; set; }

        public DB()
        {
            BookSet = new List<Book>();
            AuthorSet = new List<Author>();
            PublishingHouseSet = new List<PublishingHouse>();
            ThemeSet = new List<Theme>();
            SeriaSet = new List<Seria>();
        }
    }
}
