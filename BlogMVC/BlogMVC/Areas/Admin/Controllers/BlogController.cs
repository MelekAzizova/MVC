using BlogMVC.Contexts;
using BlogMVC.ViewModels.BlogVM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        public BlogController(BlogDbContext db)
        {
            _db = db;
        }

        BlogDbContext _db { get; }
        public async Task<IActionResult> Index()
        {
            var item = await _db.Blogs.Select(s => new BlogListItemVM
            {
                Id = s.Id,
                Name = s.Name,
                Title = s.Title,
                Author=s.Author,
                CreateAt = DateTime.Now,
                Image=s.Image,

            }).ToListAsync();
            
            return View(item);
        }
    }
}
