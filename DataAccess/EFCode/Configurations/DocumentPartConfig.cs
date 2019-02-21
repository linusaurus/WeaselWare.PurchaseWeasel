﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PurchaseWeasel.DataAccess.EFClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace PurchaseWeasel.DataAccess.Configurations
{
    public class DocumentPartConfig : IEntityTypeConfiguration<DocumentParts>
    {
        public void Configure(EntityTypeBuilder<DocumentParts> entity)
        {
            entity.HasKey(p => new { p.DocID, p.PartID });

            //---------------------------------------------
            // Relationships

            entity.HasOne(pt => pt.Parts)
                .WithMany(p => p.PartsLink)
                .HasForeignKey(pt => pt.PartID);

            entity.HasOne(pt => pt.Documents)
                .WithMany(t => t.DocumentsLink)
                .HasForeignKey(pt => pt.DocID);
        }
    }
}