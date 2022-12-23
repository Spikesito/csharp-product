using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.Model
{
    public class Core
    {
        private string password;
        private string uid;

        public Core(string pd, string u)
        {
            password = pd;
            uid = u;
        }

        public MySqlConnection ConnectDB()
        {
            string connectionString = "SERVER=localhost;DATABASE=ecom-products;UID=" + uid + ";" + "PASSWORD=" + password + ";";
            MySqlConnection cnn = new MySqlConnection(connectionString);
            return cnn;
        }

    // string server = "localhost";
    // string database = "ecom-products";
    // string uid = UserTextBox.Text;
    // string password = PassBox.Password;
}
 }

