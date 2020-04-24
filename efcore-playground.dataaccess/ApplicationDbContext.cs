using efcore_playground.dataaccess.entities;
using Microsoft.EntityFrameworkCore;

namespace efcore_playground.dataaccess
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            // options are registered in the Startup.cs file
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
