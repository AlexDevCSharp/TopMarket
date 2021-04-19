using System;
using System.Collections.Generic;
using System.Text;

namespace TopMarket.Shared.Entities
{
    public class ProductForCart
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double ProductTotal => Product.Price * Quantity;
    }
}
