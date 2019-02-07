using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PurchaseSQLDB.DataAccess.EFClasses;
using System.ComponentModel.DataAnnotations;

namespace Weaselware.Lemur.DTO
{
    public class InventoryDto
    {
        [Key]
        public int StockTransactionID { get; set; }
        public int OrderReceiptID { get; set; }
        public int PurchaseOrderID { get; set; }
        public int LineID { get; set; }
        public int? PartID { get; set; }
        public int? StockBillID { get; set; }
        public string Location { get; set; }
        public String DateStamp { get; set; }
        public decimal? Qnty { get; set; }
        public string Description { get; set; }
        public int UID { get; set; }
        public int? TransActionTypeID { get; set; }
        public string TransActionName { get; set; }
        

    }
}
