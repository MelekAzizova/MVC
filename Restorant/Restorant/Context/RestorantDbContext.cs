using Microsoft.EntityFrameworkCore;
using Restorant.Models;

namespace Restorant.Context
{
    public class RestorantDbContext:DbContext
    {
        public RestorantDbContext(DbContextOptions<RestorantDbContext> options)
        : base(options) { }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
