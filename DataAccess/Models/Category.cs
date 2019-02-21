using System.Collections.Generic;
using System.Text;
using System.Linq;
using PurchaseWeasel.DataAccess.EFClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;




namespace PurchaseWeasel.DataAccess.EFClasses
{
    public class Category
    {
        public Category()
        {
            this.PartTypes = new HashSet<PartType>();
        }

        public int Categoryid { get; set; }
        //public string Category { get; set; }
        public int? PartClassID { get; set; }

        public PartClass PartClass { get; set; }
        public ICollection<PartType> PartTypes { get; set; }
    }
}
