using System;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SomeWebApplication.Models
{
    public class ApplicationDbInitializer : DropCreateDatabaseAlways<DbContext>
    {
        protected override void Seed(DbContext context)
        {
            base.Seed(context);
        }
    }
}