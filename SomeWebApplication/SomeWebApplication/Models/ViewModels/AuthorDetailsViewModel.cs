using System.ComponentModel.DataAnnotations;
using System.Web;

namespace SomeWebApplication.Models.ViewModels
{
    public class AuthorDetailsViewModel
    {
        [Required]
        [Display(Name = "Avatar (click here)")]
        public HttpPostedFileBase AvatarFile { get; set; }

        [Required]
        public string UserId { get; set; }

        public string Name { get; set; }
    }
}