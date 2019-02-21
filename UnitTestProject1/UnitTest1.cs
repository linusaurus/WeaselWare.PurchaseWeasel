using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PurchaseWeasel.DataAccess.EFCode;
using System.Collections.Generic;
using PurchaseWeasel.DataAccess.EFClasses;
using PurchaseWeasel.DataAccess.Services;
using PurchaseWeasel.UI.ViewModels;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            List<PurchaseOrder> result = new List<PurchaseOrder>();

            using (var context = new PurchaseSQLDBContext())
            {
                PurchaseOrderService service = new PurchaseOrderService();
                result = service.GetAll();
            }

                
            Assert.IsTrue(result.Count > 200);

        }

        [TestMethod]
        public void ViewModelTest()
        {

            List<PurchaseOrder> result = new List<PurchaseOrder>();

            using (var context = new PurchaseSQLDBContext())
            {
                PurchaseOrderService service = new PurchaseOrderService();
                
                MainViewModel view = new MainViewModel(service);

                view.Load();
            }


            Assert.IsTrue(result.Count > 200);

        }
    }
}
