using System.Collections.Generic;
using TopMarket.Shared.Entities;

namespace TopMarket.Shared.DTOs
{
    public class OrderCartDTO
    {
        public int OrderId { get; set; }
        public ProductForCart Products { get; set; }
    }
}
