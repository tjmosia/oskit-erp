﻿using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

using Moskit.Models.Entity.CustomerSpace;

namespace Moskit.Models.Entity.SystemSpace
{
    public class SystemCompanySetup
    {
        public virtual string? Id { get; set; }
        public virtual string? NumberPrefix { get; set; }
        public virtual long NumberNext { get; set; }
        public virtual string? NumberFormat { get; set; }

        [Timestamp, ConcurrencyCheck]
        public virtual byte[]? RowVersion { get; set; }

        public SystemCompanySetup ()
            => Id = Guid.NewGuid().ToString("N");

        public static void BuildModel (ModelBuilder builder)
            => builder.Entity<Customer>(options =>
            {
                options.ToTable(nameof(SystemCompanySetup))
                    .HasKey(x => x.Id)
                    .IsClustered();
            });
    }
}
