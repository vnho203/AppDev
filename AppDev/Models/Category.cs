﻿using System.ComponentModel.DataAnnotations;

namespace AppDev.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]

        public string Name { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
    }
}
