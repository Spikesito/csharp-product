using System.Windows;
using System.Windows.Controls;
using ecommerce.ViewModel;


namespace ecommerce.Views
{
    /// <summary>
    /// Logique d'interaction pour Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        private Frame _frame;
        public Login(Frame nav)
        {
            _frame = nav;
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
            }
            else
            {
                _frame.Navigate(new ProductsView(log.GetConnection()));
            }
            // var temp = cnn.State.ToString();

        }
    }
}