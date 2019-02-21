using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PurchaseWeasel.DataAccess.EFClasses;
using System.ComponentModel.DataAnnotations;

namespace PurchaseWeasel.DataAccess
{
    public class PartDto
    {
        public int PartID { get; set; }
        public string Description { get; set; }   
        public string PartNumber { get; set; }
        public string Location { get; set; }
        public string SKU { get; set; }
        public decimal UnitInStock { get; set; }
    }
}
