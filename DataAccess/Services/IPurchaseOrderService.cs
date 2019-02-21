using System.Collections.Generic;
using PurchaseWeasel.DataAccess.EFClasses;

namespace PurchaseWeasel.DataAccess.Services
{
    public interface IPurchaseOrderService
    {
        List<PurchaseOrder> GetAll();
    }
}