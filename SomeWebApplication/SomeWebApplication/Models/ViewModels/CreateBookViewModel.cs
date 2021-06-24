using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Web.Mvc;

namespace SomeWebApplication.Models
{
    public class CreateBookViewModel
    {
        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Enter co-authors' mails separated by commas or leave this field blank")]
        public string Authors { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public IEnumerable<int> GenreIds { get; set; }

        [Required]
        [Display(Name = "Annotation")]
        public string Annotation { get; set; }

        [Required]
        [Display(Name = "Cover (click here)")]
        public HttpPostedFileBase CoverFile { get; set; }

        [Required]
        [Display(Name = "File with text (click here)")]
        public HttpPostedFileBase TextFile { get; set; }

        public MultiSelectList Genres { get; set; }
    }
}
