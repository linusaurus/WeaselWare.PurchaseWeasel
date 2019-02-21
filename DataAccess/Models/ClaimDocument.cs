using System.Collections.Generic;
using System.Text;
using System.Linq;
using PurchaseWeasel.DataAccess.EFClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace PurchaseWeasel.DataAccess.EFClasses
{
    public class ClaimDocument
    {
        public int ClaimDocumentID { get; set; }
        public string DocumentDesciption { get; set; }
        public string DocumentExtension { get; set; }
        public int? ClaimItemID { get; set; }

        public ClaimItem ClaimItem { get; set; }
    }
}
