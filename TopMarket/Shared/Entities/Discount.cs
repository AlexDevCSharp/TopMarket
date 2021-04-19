using System.ComponentModel.DataAnnotations;

namespace TopMarket.Shared.Entities
{
    public class Discount
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Amount is required.")]
        public double Amount { get; set; }
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }
    }
}
