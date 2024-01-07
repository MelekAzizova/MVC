using BlogMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogMVC.Contexts
{
    public class BlogDbContext:DbContext
    {
        public BlogDbContext(DbContextOptions opt) :base(opt)
        {
            
        }

        public DbSet<Blog> Blogs { get; set; }
    }
}
