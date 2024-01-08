namespace BlogMVC.ViewModels.BlogVM
{
    public class BlogCreateVM
    {
        public IFormFile Image { get; set; }

        public string Author { get; set; }
        public DateTime CreateAt { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }
    }
}
