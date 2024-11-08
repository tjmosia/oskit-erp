﻿using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

namespace OskitBlazor.Models.Entity.AccountingSpace
{
    public class AccountCashFlowType
    {
        public virtual string? Id { get; set; }
        public virtual string? Name { get; set; }
        public virtual string? Description { get; set; }

        [Timestamp]
        [ConcurrencyCheck]
        public virtual byte[]? RowVersion { get; set; }

        public AccountCashFlowType ()
            => Guid.NewGuid().ToString("N");

        public static void BuildModel (ModelBuilder builder)
        {
            builder.Entity<AccountCashFlowType>(options =>
            {
                options.ToTable(nameof(AccountCashFlowType))
                    .HasKey(x => x.Id)
                    .IsClustered();

                options.HasMany<AccountCategory>()
                    .WithOne(p => p.CashFlowType)
                    .HasForeignKey(p => p.CashFlowTypeId)
                        .IsRequired(true)
                    .OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}
