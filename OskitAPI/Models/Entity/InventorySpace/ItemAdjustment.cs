﻿using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

using OskitAPI.Core.Types;
using OskitAPI.Models.Entity.CompanySpace;

namespace OskitAPI.Models.Entity.InventorySpace
{
    public class ItemAdjustment
    {
        public virtual string? Id { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual string? Reason { get; set; }
        public virtual string? ItemId { get; set; }
        public virtual decimal OldQuantityOnHand { get; set; }
        public virtual decimal QuantityOnHand { get; set; }
        public virtual decimal OldPrice { get; set; }
        public virtual decimal Price { get; set; }
        public virtual string? CompanyId { get; set; }
        public virtual bool FromSales { get; set; }

        [Timestamp, ConcurrencyCheck]
        public virtual byte[]? RowVersion { get; set; }

        public virtual Item? Item { get; set; }
        public virtual Company? Company { get; set; }

        public ItemAdjustment ()
            => Id = Guid.NewGuid().ToString("N");

        public static void BuildModel (ModelBuilder builder)
        {
            builder.Entity<ItemAdjustment>(options =>
            {
                options.ToTable(nameof(ItemAdjustment))
                    .HasKey(p => p.Id)
                    .IsClustered(false);

                options.HasIndex(p => new { p.CompanyId, p.ItemId })
                    .IsClustered();

                options.Property(p => p.QuantityOnHand)
                    .HasColumnType(ColumnTypes.Number);

                options.Property(p => p.OldQuantityOnHand)
                    .HasColumnType(ColumnTypes.Number);

                options.Property(p => p.Price)
                    .HasColumnType(ColumnTypes.Monetary);

                options.Property(p => p.OldPrice)
                    .HasColumnType(ColumnTypes.Monetary);

            });
        }
    }
}
