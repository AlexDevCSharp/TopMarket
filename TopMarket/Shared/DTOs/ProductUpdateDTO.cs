using System;
using System.Collections.Generic;
using System.Text;
using TopMarket.Shared.Entities;

namespace TopMarket.Shared.DTOs
{
    public class ProductUpdateDTO
    {
        public Product Product { get; set; }
        //public List<Person> Actors { get; set; }
        public List<Category> SelectedCategories { get; set; }
        public List<Category> NotSelectedCategories { get; set; }
    }
}
