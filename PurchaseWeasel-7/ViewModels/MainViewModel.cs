using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PurchaseWeasel.DataAccess.Services;
using PurchaseWeasel.DataAccess.EFClasses;
using System.ComponentModel;

namespace PurchaseWeasel.UI.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        
        

        private IPurchaseOrderService _purchaseOrderService;
        private PurchaseOrder _selectedPurchaseOrder;

        public MainViewModel(IPurchaseOrderService purchaseOrderService)
        {
            PurchaseOrders = new List<PurchaseOrder>();
            _purchaseOrderService = purchaseOrderService;
           
        }

        public void Load()
        {

           //PurchaseOrders.Clear();      
           PurchaseOrders = _purchaseOrderService.GetAll();
           
        }

        public List<PurchaseOrder> PurchaseOrders { get; set; }

        public PurchaseOrder SelectedOrder
        {
            get { return _selectedPurchaseOrder; }
            set {
                _selectedPurchaseOrder = value;
                OnPropertyChanged();
            }
        }


       
    }
}
