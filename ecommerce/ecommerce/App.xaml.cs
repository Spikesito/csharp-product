using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ecommerce.ViewModel;

namespace ecommerce
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new VMProductsView()
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
