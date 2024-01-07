using System.ComponentModel.DataAnnotations;

namespace BlogMVC.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Required,MaxLength(128)]
        public string Image {  get; set; }
        [Required,MaxLength(128)]
        public string Author { get; set; }
        public DateTime CreateAt { get; set; }
        [Required] 
        public string Name { get; set; }
        [Required]
        public string Title { get; set; }
    }
}
