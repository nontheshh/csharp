
using System.ComponentModel.DataAnnotations;

namespace SomeWebApplication.Models.ViewModels
{
    public class CommentViewModel
    {
        [Required]
        [Display(Name = "Комментарий")]
        public string Text { get; set; }

        public int BookId { get; set; }
    }
}