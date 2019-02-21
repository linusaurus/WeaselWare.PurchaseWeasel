﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PurchaseWeasel.DataAccess.EFClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PurchaseWeasel.DataAccess.Configurations
{
    public class ClaimItemConfig : IEntityTypeConfiguration<ClaimItem>
    {
        public void Configure(EntityTypeBuilder<ClaimItem> entity)
        {
            entity.HasKey(p => p.ClaimItemID);
            entity.HasMany(r => r.ClaimDocuments)
                .WithOne().HasForeignKey(l => l.ClaimItemID)
                .IsRequired().OnDelete(DeleteBehavior.Cascade);
        }
    }
}