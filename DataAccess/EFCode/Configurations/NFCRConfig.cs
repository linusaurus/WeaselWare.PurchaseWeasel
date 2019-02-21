using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PurchaseWeasel.DataAccess.EFClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PurchaseWeasel.DataAccess.Configurations
{
    public class NFCRConfig : IEntityTypeConfiguration<NFRC>
    {
        public void Configure(EntityTypeBuilder<NFRC> entity)
        {
            entity.HasKey(p => p.CPD_ID);
        }
    }
}