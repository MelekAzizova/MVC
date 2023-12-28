﻿namespace Restorant.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

    }
}