
using System.Data.Entity;

namespace DbManagerEntityFramework.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }


        public AppDbContext() : base("DbConnectionString")
        {
            Database.SetInitializer<AppDbContext>(
               new DropCreateDatabaseIfModelChanges<AppDbContext>());
        }

        public static AppDbContext Create()
        {
            return new AppDbContext();
        }
    }
}
