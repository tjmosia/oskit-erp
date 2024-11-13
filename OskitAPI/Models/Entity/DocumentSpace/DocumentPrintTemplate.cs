﻿using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

namespace OskitAPI.Models.Entity.DocumentSpace
{
    public class DocumentPrintTemplate
    {
        public virtual string? Id { get; set; }
        public virtual string? Name { get; set; }
        public virtual string? Description { get; set; }
        public virtual string? DocumentType { get; set; }

        [ConcurrencyCheck]
        public virtual string? RowVersion { get; set; }

        public void UpdateConcurrencyToken ()
            => RowVersion = Guid.NewGuid().ToString("N");

        public DocumentPrintTemplate ()
            => Id = Guid.NewGuid().ToString("N");

        public static void BuildModel (ModelBuilder builder)
            => builder.Entity<DocumentPrintTemplate>(options =>
            {
                options.ToTable(nameof(DocumentPrintTemplate))
                    .HasKey(p => p.Id)
                    .IsClustered();

                options.HasMany<DocumentSetup>()
                    .WithOne(p => p.PrintTemplate)
                    .HasForeignKey(p => p.PrintTemplateId)
                        .IsRequired()
                    .OnDelete(DeleteBehavior.Restrict);
            });
    }
}
