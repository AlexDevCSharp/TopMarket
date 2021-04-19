using System;
using System.Collections.Generic;
using System.Text;
using TopMarket.Shared.Entities;

namespace TopMarket.Shared.DTOs
{
    public class CartTotal
    {
        public List<ProductForCart> Products { get; set; }
        public double Total { get; set; }
    }
}
