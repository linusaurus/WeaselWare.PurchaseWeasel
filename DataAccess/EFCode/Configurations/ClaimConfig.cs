﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PurchaseWeasel.DataAccess.EFClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PurchaseWeasel.DataAccess.Configurations
{
    public class ClaimConfig : IEntityTypeConfiguration<Claim>
    {
        public void Configure(EntityTypeBuilder<Claim> entity)
        {
            entity.HasKey(p => p.ClaimID);

            //---------------------------------------------
            //Relationships

            
           // entity.HasMany(p => p.ClaimItems.Wirh().HasForeignKey(d => d.ClaimID)
           //    .IsRequired()
           //     .OnDelete(DeleteBehavior.Cascade);
        }
    }
}