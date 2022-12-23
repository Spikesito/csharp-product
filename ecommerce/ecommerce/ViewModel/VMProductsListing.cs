using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.ViewModel
{
    public class VMProductsListing : VMBase
    {
        private readonly ObservableCollection<VMProductsListingItem> _vmProductsListingItem;
        public IEnumerable<VMProductsListingItem> VMProductsListingItems => _vmProductsListingItem;
        
        public VMProductsListing()
        {
            _vmProductsListingItem = new ObservableCollection<VMProductsListingItem>();

            _vmProductsListingItem.Add(new VMProductsListingItem("Dunk Low - Nike"));
            _vmProductsListingItem.Add(new VMProductsListingItem("Vapormax - Nike"));
            _vmProductsListingItem.Add(new VMProductsListingItem("TN - Nike"));

        }
    }
}
