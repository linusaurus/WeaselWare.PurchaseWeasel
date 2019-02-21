using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PurchaseWeasel.DataAccess.EFClasses;

namespace PurchaseWeasel.DataAccess.EFClasses
{
    public class TransActionType
    {
        public int TransactionsTypeID { get; set; }
        public string TransactionTypeName { get; set; }
    }
}
