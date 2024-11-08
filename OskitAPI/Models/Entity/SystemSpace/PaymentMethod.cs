﻿using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

using OskitAPI.Models.Entity.BankingSpace;
using OskitAPI.Models.Entity.PurchasesSpace;
using OskitAPI.Models.Entity.SalesSpace;

namespace OskitAPI.Models.Entity.SystemSpace
{
    public class PaymentMethod
    {
        public virtual string? Id { get; set; }
        public virtual string? Name { get; set; }
        public virtual string? Type { get; set; }
        public virtual string? Description { get; set; }

        [Timestamp, ConcurrencyCheck]
        public virtual byte[]? RowVersion { get; set; }

        public PaymentMethod ()
            => Id = Guid.NewGuid().ToString("N");

        public static void BuildModel (ModelBuilder builder)
            => builder.Entity<PaymentMethod>(options =>
            {
                options.ToTable(nameof(PaymentMethod))
                    .HasKey(x => x.Id);

                options.HasIndex(p => p.Name)
                    .IsUnique();

                options.HasMany<BankAccount>()
                    .WithOne(p => p.PaymentMethod)
                    .HasForeignKey(p => p.PaymentMethodId)
                        .IsRequired()
                    .OnDelete(DeleteBehavior.Restrict);

                options.HasMany<SalesReceipt>()
                    .WithOne(p => p.PaymentMethod)
                    .HasForeignKey(p => p.PaymentMethodId)
                        .IsRequired()
                    .OnDelete(DeleteBehavior.Restrict);

                options.HasMany<PurchaseReceipt>()
                    .WithOne(p => p.PaymentMethod)
                    .HasForeignKey(p => p.PaymentMethodId)
                        .IsRequired()
                    .OnDelete(DeleteBehavior.Restrict);
            });
    }
}
