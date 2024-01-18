using Bulky.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAcess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
    }
}
