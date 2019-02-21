using Autofac;
using PurchaseWeasel.DataAccess.Services;
using PurchaseWeasel.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PurchaseWeasel.UI;

namespace PurchaseWeasel.UI.Startup
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();


            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<PurchaseOrderService>().As<IPurchaseOrderService>();

            return builder.Build();

        }

    
    }
}
