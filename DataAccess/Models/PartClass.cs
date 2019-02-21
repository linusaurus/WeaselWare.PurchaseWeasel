using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PurchaseWeasel.DataAccess.EFClasses;

namespace PurchaseWeasel.DataAccess.EFClasses
{
    public class PartClass
    {
        public PartClass()
        {
            this.Categories = new HashSet<Category>();
        }

        public int PartClassID { get; set; }
        //public string PartClass { get; set; }

        public ICollection<Category> Categories { get; set; }
    }
}
