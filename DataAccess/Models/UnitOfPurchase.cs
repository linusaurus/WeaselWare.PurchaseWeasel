using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PurchaseWeasel.DataAccess.EFClasses;

namespace PurchaseWeasel.DataAccess.EFClasses
{
    public class UnitOfPurchase
    {
        public int UoPID { get; set; }
        public int PartID { get; set; }
        public int? UID { get; set; }
        public string UOPName { get; set; }
        public decimal? UOPCostUnit { get; set; }
        public decimal? UOPRatio { get; set; }

        public Part Part { get; set; }
    }
}
