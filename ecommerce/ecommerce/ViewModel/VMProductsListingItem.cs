using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ecommerce.ViewModel
{
    public class VMProductsListingItem : VMBase
    {
        public string ProductName { get; }
        /// <summary>
        /// public ICommand EditCommand { get; }
        /// </summary>
        ///public ICommand DeleteCommand { get; }
        public VMProductsListingItem(string productName)
        {
            ProductName = productName;
        }
    }
}
