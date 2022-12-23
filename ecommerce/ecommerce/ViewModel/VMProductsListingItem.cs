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
        public int Id { get; }
        public string ProductName { get; }
        public int Quantity { get; }
        public float Price { get;}

        public ICommand EditCommand { get; } = default!;
        public ICommand DeleteCommand { get; } = default!;
        public VMProductsListingItem(int id, string productName, int quantity, float price)
        {
            Id = id;
            ProductName = productName;
            Quantity = quantity;
            Price = price;
        }
    }
}
