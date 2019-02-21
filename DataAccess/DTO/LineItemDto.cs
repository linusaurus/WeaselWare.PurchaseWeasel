using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PurchaseWeasel.DataAccess.EFClasses;
using PurchaseWeasel.DataAccess.EFCode;

namespace PurchaseWeasel.DataAccess
{
    public class LineItemDto
    {
        public int LineID { get; set; }
        public int PurchaseOrderID { get; set; }
        public int? PartID { get; set; }
        public decimal Quantity { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Extended { get; set; }
    }
}
