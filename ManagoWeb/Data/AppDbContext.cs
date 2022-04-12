using ManagoWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace ManagoWeb.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
