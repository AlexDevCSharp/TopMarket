using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMarket.Shared.Entities;

namespace TopMarket.Shared.DTOs
{
    public class ProductDiscountDto
    {
        public Product Product { get; set; }
        public double LastPrice { get; set; }
    }
}
