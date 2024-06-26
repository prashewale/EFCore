﻿using System.ComponentModel.DataAnnotations;

namespace EFCore.Inventory.Models
{
    public class Player : FullAuditModel
    {
        [StringLength(InventoryModelsConstants.MAX_PLAYERNAME_LENGTH)]
        public string Name { get; set; } = string.Empty;

        [StringLength(InventoryModelsConstants.MAX_PLAYERDESCRIPTION_LENGTH)]
        public string? Description { get; set; }

        public virtual List<Item> Items { get; set; } = new List<Item>();
    }
}
