using ecommerce.Model;
using ecommerce.ViewModel;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ecommerce.Components
{
    /// <summary>
    /// Logique d'interaction pour ProductsListing.xaml
    /// </summary>
    public partial class ProductsListing : UserControl
    {
        public MySqlConnection conn;
        public ProductsListing(MySqlConnection conn)
        {
            this.conn = conn;
        }
        public ProductsListing()
        {
            
            InitializeComponent();
            List<VMProductsListingItem> items = new List<VMProductsListingItem>();
            ///items.Add(new VMProductsListingItem(1, "AF1", 12, 1));
            ProductCRUD CRUD = new ProductCRUD(conn);
            items = CRUD.Read();

            dataProducts.ItemsSource = items;
        }
    }
}
