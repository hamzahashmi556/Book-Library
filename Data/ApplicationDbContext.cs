using Book_Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Book_Library.Database
{
    public class ApplicationDbContext : DbContext
    {
        // this constructor takes options from parameters and pass it to parent class which is DbContext
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
