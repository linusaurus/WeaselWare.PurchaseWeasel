using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PurchaseWeasel.DataAccess.EFClasses;
using PurchaseWeasel.DataAccess.EFCode;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PurchaseWeasel.DataAccess
{
    public class SuppliersListDto
    {
        [Key]
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        [DisplayFormat(DataFormatString = "{0:C0}", ApplyFormatInEditMode = true)]
        public decimal OrderTotals { get; set; }
    }
}
