using System.ComponentModel.DataAnnotations;

namespace BlogMVC.ViewModels.BlogVM
{
    public class BlogListItemVM
    {
        public int Id { get; set; }
       
        public string Image { get; set; }
        
        public string Author { get; set; }
        public DateTime CreateAt { get; set; }
        
        public string Name { get; set; }
        
        public string Title { get; set; }
    }
}
