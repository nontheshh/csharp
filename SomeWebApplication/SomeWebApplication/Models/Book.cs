
using System;
using System.Collections.Generic;

namespace SomeWebApplication.Models
{
    public class Book
    {
        public Book()
        {
            Genres = new List<Genre>();
            ApplicationUsers = new List<ApplicationUser>();
            Comments = new List<Comment>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Annotation { get; set; }
        public string Text { get; set; }
        public string Status { get; set; }
        public byte[] CoverBytes { get; set; }
        public DateTime TimeStamp { get; set; }

        public IList<Genre> Genres { get; set; }
        public IList<ApplicationUser> ApplicationUsers { get; set; }
        public IList<Comment> Comments { get; set; }
    }
}