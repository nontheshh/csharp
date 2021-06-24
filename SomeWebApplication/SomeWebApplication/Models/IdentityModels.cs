using System.Collections.Generic;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SomeWebApplication.Models
{
    // В профиль пользователя можно добавить дополнительные данные, если указать больше свойств для класса ApplicationUser. Подробности см. на странице https://go.microsoft.com/fwlink/?LinkID=317594.
    public class ApplicationUser : IdentityUser
    {
        public IList<Book> Books { get; set; }
        public IList<Comment> Comments { get; set; }
        public byte[] AvatarBytes { get; set; }

        public ApplicationUser()
        {
            Books = new List<Book>();
            Comments = new List<Comment>();
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Обратите внимание, что authenticationType должен совпадать с типом, определенным в CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Здесь добавьте утверждения пользователя
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<BookRating> BookRatings { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<CommentRating> CommentRatings { get; set; }

        public DbSet<TwoPointRating> TwoPointRatings { get; set; }
        public DbSet<FivePointRating> FivePointRatings { get; set; }



        public ApplicationDbContext()
            : base("SomeWebApplicationConnectionString", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}