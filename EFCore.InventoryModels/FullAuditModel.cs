﻿using EFCore.InventoryModels.Interfaces;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EFCore.InventoryModels
{
    public abstract class FullAuditModel : IIdentityModel,
        IAuditedModel, IActivableModel, ISoftDeletable
    {
        [Key]
        public int Id { get; set; }

        [StringLength(InventoryModelsConstants.MAX_USERID_LENGTH)]
        public string CreatedByUserId { get; set; }

        public DateTime CreatedDate { get; set; }
       
        [StringLength(InventoryModelsConstants.MAX_USERID_LENGTH)]
        public string? LastModifiedUserId { get; set; }
        
        public DateTime? LastModifiedDate { get; set; }
        
        public bool IsActive { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
    }
}
