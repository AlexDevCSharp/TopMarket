using System;
using System.Collections.Generic;
using System.Text;
using TopMarket.Shared.Entities;

namespace TopMarket.Shared.DTOs
{
    public class DetailsProductDTO
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}
