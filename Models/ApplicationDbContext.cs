using Microsoft.EntityFrameworkCore;

namespace AdminDashboard_UI.Models
{
    public class ApplicationDbContext : DbContext
    {
        // ctor 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Products> Products { get; set; }
    }
}
