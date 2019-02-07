using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PurchaseSQLDB.DataAccess.EFClasses;
using PurchaseSQLDB.DataAccess.EFCode;

namespace Weaselware.Lemur.DTO
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
