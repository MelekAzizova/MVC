using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restorant.Context;
using Restorant.ViewModels.CategoryVM;

namespace Restorant.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        public CategoryController(RestorantDbContext db)
        {
            _db = db;
        }

        RestorantDbContext _db { get; }
        public async Task<IActionResult> Index(CategoryListVM vm)
        {
            return View(await _db.Categories.Select(s => new CategoryListVM
            {
                Id = s.Id,
                Name = s.Name


            }).ToListAsync());
        }
    }
}
