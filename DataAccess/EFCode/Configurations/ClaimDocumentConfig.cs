using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PurchaseWeasel.DataAccess.EFClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PurchaseWeasel.DataAccess.Configurations
{
    public class ClaimDocumentConfig : IEntityTypeConfiguration<ClaimDocument>
    {
        public void Configure(EntityTypeBuilder<ClaimDocument> entity)
        {
            entity.HasKey(p => p.ClaimDocumentID);
        }
    }
}