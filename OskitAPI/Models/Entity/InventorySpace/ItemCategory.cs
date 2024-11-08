﻿using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

using OskitAPI.Models.Entity.CompanySpace;

namespace OskitAPI.Models.Entity.InventorySpace
{
    public class ItemCategory
    {
        public virtual string? Id { get; set; }
        public virtual string? Name { get; set; }
        public virtual string? Description { get; set; }
        public virtual string? CompanyId { get; set; }
        public virtual string? ParentId { get; set; }

        [Timestamp, ConcurrencyCheck]
        public virtual byte[]? RowVersion { get; set; }

        public virtual ItemCategory? Parent { get; set; }
        public virtual Company? Company { get; set; }
        public virtual ICollection<Item>? Items { get; set; }
        public virtual ICollection<ItemCategory>? SubCategories { get; set; }

        public ItemCategory ()
            => Id = Guid.NewGuid().ToString("N");

        public static void BuildModel (ModelBuilder builder)
            => builder.Entity<ItemCategory>(options =>
            {
                options.ToTable(nameof(ItemCategory))
                    .HasKey(p => p.Id)
                    .IsClustered(false);

                options.HasIndex(p => p.CompanyId)
                    .IsClustered();

                options.HasMany(p => p.SubCategories)
                    .WithOne(p => p.Parent)
                    .HasForeignKey(p => p.ParentId)
                        .IsRequired(true)
                    .OnDelete(DeleteBehavior.Restrict);

                options.HasMany(p => p.Items)
                    .WithOne(p => p.Category)
                    .HasForeignKey(p => p.CategoryId)
                        .IsRequired(false)
                    .OnDelete(DeleteBehavior.SetNull);
            });
    }
}
