using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PurchaseWeasel.DataAccess.EFClasses;

namespace PurchaseWeasel.DataAccess.EFClasses
{
    public class Manu
    {
        public int ManuID { get; set; }
        public string Manufacturer { get; set; }
        public string Phone { get; set; }
        public string WebAddress { get; set; }
        public int? ManuCategoryID { get; set; }
    }
}
