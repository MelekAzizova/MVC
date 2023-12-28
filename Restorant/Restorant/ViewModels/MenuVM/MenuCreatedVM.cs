using Restorant.Models;

namespace Restorant.ViewModels.MenuVM
{
    public class MenuCreatedVM
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IFormFile ImageFile { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
