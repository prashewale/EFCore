﻿namespace EFCore.Inventory.Models.DTOs
{
    public class FullItemDetailsDTO
    {
        public int Id { get; set; }
        public string? ItemName { get; set; }
        public string? ItemDescription { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public string? Notes { get; set; }
        public decimal? CurrentOrFinalPrice { get; set; }
        public bool IsOnSale { get; set; }
        public decimal? PurchasePrice { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public int? Quantity { get; set; }
        public DateTime? SoldDate { get; set; }
        public string? Category { get; set; }
        public bool? CategoryIsActive { get; set; }
        public bool? CategoryIsDeleted { get; set; }
        public string? ColorName { get; set; }
        public string? ColorValue { get; set; }
        public string? PlayerName { get; set; }
        public string? PlayerDescription { get; set; }
        public bool? PlayerIsActive { get; set; }
        public bool? PlayerIsDeleted { get; set; }
        public string? GenreName { get; set; }
        public bool? GenreIsActive { get; set; }
        public bool? GenreIsDeleted { get; set; }

    }
}
