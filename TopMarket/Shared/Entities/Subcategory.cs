using System;
using System.Collections.Generic;
using System.Text;

namespace TopMarket.Shared.Entities
{
    public class Subcategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
