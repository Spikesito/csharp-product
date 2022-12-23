using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ecommerce.ViewModel
{
    public class VMProductsView : VMBase
    {
        /// public VMBase CurrentViewModel { get; }
        public VMProductsListing VMProductsListing { get; }
        public VMProductsDetails VMProductsDetails { get; }
        public ICommand AddProductsCommand { get; } 

        public VMProductsView ()
        {
            VMProductsListing = new VMProductsListing ();
            VMProductsDetails = new VMProductsDetails ();
        }
    }
}
