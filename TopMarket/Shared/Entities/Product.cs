using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TopMarket.Shared.Entities
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Price is required.")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Brand is required.")]
        public string Brand { get; set; }
        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }
        public string Summary { get; set; }
        //public int Quantity { get; set; }
        public string Poster { get; set; }
        //public DateTime ReleaseDate { get; set; }
        //public List<ProductsCategories> ProductsCategories { get; set; }  = new List<ProductsCategories>();
        public string TitleBrief
        {
            get
            {
                if (string.IsNullOrEmpty(Title))
                {
                    return null;
                }

                if (Title.Length > 60)
                {
                    return Title.Substring(0, 60) + "...";
                }
                else
                {
                    return Title;
                }
            }
        }
        public int SubcatId { get; set; }
        [Required(ErrorMessage = "Weight is required.")]
        public int Weight { get; set; }
    }
}
