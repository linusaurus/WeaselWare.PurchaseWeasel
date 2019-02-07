using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PurchaseSQLDB.DataAccess.EFClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PurchaseSQLDB.DataAccess.EFCode
{
    public class AccountTypeConfig : IEntityTypeConfiguration<AccountType>
    {
        public void Configure(EntityTypeBuilder<AccountType> entity)
        {
            entity.HasKey(p => p.AccountTypeID);
        }
    }
}