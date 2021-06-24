using PagedList;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SomeWebApplication.Models
{
    public class SearchBookViewModel
    {
        [Display(Name = "Title")]
        public string SearchTitleString { get; set; }

        [Display(Name = "Genre")]
        public string SearchGenreString { get; set; }

        [Display(Name = "Author")]
        public string SearchAuthorString { get; set; }

        public List<string> GenreNames { get; set; }
        public IPagedList<Book> FoundBooks { get; set; }
    }
}