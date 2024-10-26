﻿using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

using Moskit.Core.Types;
using Moskit.Models.Entity.CompanySpace;

namespace Moskit.Models.Entity.PurchasesSpace
{
    public class PurchaseLine
    {
        public virtual string? Id { get; set; }
        public virtual bool IsItemType { get; set; }
        public virtual string? ItemCode { get; set; }
        public virtual string? AccountId { get; set; }
        public virtual string? Description { get; set; }
        public virtual string? Unit { get; set; }
        public virtual decimal Price { get; set; }
        public virtual decimal DiscountRate { get; set; }
        public virtual decimal TaxRate { get; set; }
        public virtual string? VATId { get; set; }
        public virtual string? DocumentId { get; set; }
        public virtual string? Comment { get; set; }

        [Timestamp, ConcurrencyCheck]
        public virtual byte[]? RowVersion { get; set; }

        public virtual ICollection<PurchaseDocumentLine>? DocumentLines { get; set; }
        public virtual CompanyValueAddedTax? VAT { get; set; }

        public PurchaseLine ()
            => Id = Guid.NewGuid().ToString("N");

        public static void BuildModel (ModelBuilder builder)
            => builder.Entity<PurchaseLine>(options =>
            {
                options.ToTable(nameof(PurchaseLine))
                    .HasKey(p => p.Id)
                    .IsClustered(true);

                options.Property(p => p.Price)
                    .HasColumnType(ColumnTypes.Monetary);

                options.Property(p => p.TaxRate)
                    .HasColumnType(ColumnTypes.Percentage);

                options.Property(p => p.DiscountRate)
                    .HasColumnType(ColumnTypes.Percentage);

                options.HasMany(p => p.DocumentLines)
                    .WithOne(p => p.Line)
                    .HasForeignKey(p => p.LineId)
                        .IsRequired()
                    .OnDelete(DeleteBehavior.Cascade);
            });
    }
}
