﻿using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

namespace OskitAPI.Models.Entity.SystemSpace
{
    public class Country
    {
        public virtual string? Code { get; set; }
        public virtual string? Name { get; set; }
        public virtual string? DialingCode { get; set; }

        [Timestamp, ConcurrencyCheck]
        public virtual byte[]? RowVersion { get; set; }

        public static void BuildModel (ModelBuilder builder)
            => builder.Entity<Country>(options =>
            {
                options.ToTable(nameof(Country))
                    .HasKey(x => x.Code)
                    .IsClustered();

                options.HasIndex(p => p.Name)
                    .IsUnique();

                options.Property(p => p.Code)
                    .HasMaxLength(3);
            });
    }
}
