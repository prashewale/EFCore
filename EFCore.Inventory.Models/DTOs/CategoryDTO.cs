﻿namespace EFCore.Inventory.Models.DTOs
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string? Category { get; set; }
        public CategoryDetailDTO? CategoryDetails { get; set; }
    }
}
