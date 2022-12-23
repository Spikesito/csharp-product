using ecommerce.ViewModel;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.Model
{
    class ProductCRUD
    {
        private MySqlConnection conn;
        public ProductCRUD(MySqlConnection conn) { 
             this.conn = conn;
        }
        public List<VMProductsListingItem> Read(int productid = 0)
        {
            string statement = (productid != 0) ? $"SELECT * FROM products WHERE ProductId={productid}" : "SELECT * FROM products";
            string connectionString = "SERVER=localhost;DATABASE=ecom-products;UID=root;PASSWORD=;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(statement, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            List<VMProductsListingItem> listProducts = new List<VMProductsListingItem>();
            while (dataReader.Read())
            {
                VMProductsListingItem product = new VMProductsListingItem(
                    dataReader.GetInt32(0),
                    dataReader.GetString(1),
                    dataReader.GetInt32(2),
                    dataReader.GetFloat(3)
                 );
                listProducts.Add(product);
            }
            return listProducts;
        }
    }
}
