using System.Collections.Generic;
using System.Text;
using System.Linq;
using PurchaseWeasel.DataAccess.EFClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;




namespace PurchaseWeasel.DataAccess.EFClasses
{
    public class AccountType
    {
        public int AccountTypeID { get; set; }
        //public string AccountType { get; set; }
    }
}
