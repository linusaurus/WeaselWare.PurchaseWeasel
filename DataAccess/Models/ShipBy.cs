using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PurchaseSQLDB.DataAccess.EFClasses;

namespace PurchaseSQLDB.DataAccess.EFClasses
{
    public class ShipBy
    {
        public int ShipID { get; set; }
        public string ShipByName { get; set; }
    }
}
