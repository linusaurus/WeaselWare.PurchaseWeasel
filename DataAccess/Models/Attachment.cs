using System.Collections.Generic;
using System.Text;
using System.Linq;
using PurchaseWeasel.DataAccess.EFClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace PurchaseWeasel.DataAccess.EFClasses
{
    public class Attachment
    {
        public int AttachmentID { get; set; }
        public string AttachmentDescription { get; set; }
        public int? OrderNum { get; set; }
        public string Ext { get; set; }
        public string src { get; set; }

        public PurchaseOrder PurchaseOrder { get; set; }
    }
}
