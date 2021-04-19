using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TopMarket.Shared.Entities
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="This field is required")]
        public string Name { get; set; }
        public List<Subcategory> Subcategories { get; set; }
        //public List<ProductsCategories> ProductsCategories { get; set; }  = new List<ProductsCategories>();

    }
}
