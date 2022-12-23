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
using MySqlConnector;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using ecommerce.Views;
using AngleSharp.Browser.Dom;

///using System.Windows.Forms;

namespace ecommerce
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : INavigator
    {
        public MainWindow()
        {
            InitializeComponent();
            Navigate(new Login(LoginFrame));
        }

        string INavigatorId.Version => throw new NotImplementedException();

        string INavigatorId.Platform => throw new NotImplementedException();

        string INavigatorId.UserAgent => throw new NotImplementedException();

        bool INavigatorOnline.IsOnline => throw new NotImplementedException();

        public void Navigate(Page p)
        {
            LoginFrame.Navigate(p);
        }

        bool INavigatorContentUtilities.IsContentHandlerRegistered(string mimeType, string url)
        {
            throw new NotImplementedException();
        }

        bool INavigatorContentUtilities.IsProtocolHandlerRegistered(string scheme, string url)
        {
            throw new NotImplementedException();
        }

        void INavigatorContentUtilities.RegisterContentHandler(string mimeType, string url, string title)
        {
            throw new NotImplementedException();
        }

        void INavigatorContentUtilities.RegisterProtocolHandler(string scheme, string url, string title)
        {
            throw new NotImplementedException();
        }

        void INavigatorContentUtilities.UnregisterContentHandler(string mimeType, string url)
        {
            throw new NotImplementedException();
        }

        void INavigatorContentUtilities.UnregisterProtocolHandler(string scheme, string url)
        {
            throw new NotImplementedException();
        }

        void INavigatorStorageUtilities.WaitForStorageUpdates()
        {
            throw new NotImplementedException();
        }
    }
}