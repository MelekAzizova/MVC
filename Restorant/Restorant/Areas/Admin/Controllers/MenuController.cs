using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Restorant.Context;
using Restorant.Helpers;
using Restorant.Models;
using Restorant.ViewModels.MenuVM;
using System.Drawing;

namespace Restorant.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MenuController : Controller
    {
        public MenuController(RestorantDbContext db)
        {
            _db = db;
        }

        RestorantDbContext _db { get; }
        public async  Task<IActionResult> Index(MenuListItemVM vm)
        {

            return View(await _db.Menus.Select(s => new MenuListItemVM
            {
                Id= s.Id,
                Name= s.Name,
                Description= s.Description,
                Image=s.Image,
                CategoryId= s.CategoryId,
                Price=s.Price,

            }).ToListAsync());
        }
        public IActionResult Create()
        {
            ViewBag.Categories = _db.Categories.ToList();
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(MenuCreatedVM vm)
        {
            if(vm.ImageFile != null)
            {
                if (vm.ImageFile.IsValidSize())
                {
                    ModelState.AddModelError("ImageFile", "Wrong file size");
                }
                else if(vm.ImageFile.IsValidType())
                {
                    ModelState.AddModelError("ImageFile","Wrong file type");
                }

            }
            if (!ModelState.IsValid)
            {

                ViewBag.Categories = new SelectList(_db.Categories.ToList());   
                return View();
            }


            Menu menu = new Menu
            {
                Name=vm.Name,
                Description=vm.Description,
                Price= vm.Price,
                Image=await vm.ImageFile.SaveAsync(PathConst.Menu)



            };
            _db.Menus.AddAsync(menu);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
