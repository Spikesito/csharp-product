using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ecommerce.Model;
using MySqlConnector;

namespace ecommerce.ViewModel
{
    public class VMLogin : Core
    {
        public VMLogin(string pd, string u) : base(pd, u)
        {
        }

        public MySqlConnection GetConnection()
        {
            MySqlConnection cnn = ConnectDB();
            cnn.Open();
            return cnn;
        }
        public string CheckLogin()
        {
            MySqlConnection cnn = ConnectDB();
            try
            {
                cnn.Open();
                return "ok";
            }
            catch (Exception err)
            {
                return "Error";
            }
            finally
            {
                cnn.Close();
            }
        }

    }
}
