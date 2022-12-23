using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
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
using ecommerce.ViewModel;

namespace ecommerce.Views
{
    /// <summary>
    /// Logique d'interaction pour Login.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string uid = UserTextBox.Text;
            string password = PassBox.Password;
            VMLogin log = new VMLogin(password, uid);
            if (log.CheckLogin() == "Error")
            {
                MessageBox.Show("Erreur lors de la connexion", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            } else
            {
                MessageBox.Show("GG", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            // var temp = cnn.State.ToString();

        }
    }
}
