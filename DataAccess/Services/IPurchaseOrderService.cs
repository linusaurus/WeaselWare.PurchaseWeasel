using System.Collections.Generic;
using PurchaseSQLDB.DataAccess.EFClasses;

namespace PurchaseSQLDB.DataAccess.Services
{
    public interface IPurchaseOrderService
    {
        List<PurchaseOrder> GetAll();
    }
}