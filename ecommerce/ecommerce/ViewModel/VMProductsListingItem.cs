using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ecommerce.ViewModel
{
    public class VMProductsListingItem : VMBase
    {
        public string ProductName { get; }
        public ICommand EditCommand { get; } = default!;
        public ICommand DeleteCommand { get; } = default!;
        public VMProductsListingItem(string productName)
        {
            ProductName = productName;
        }
    }
}
