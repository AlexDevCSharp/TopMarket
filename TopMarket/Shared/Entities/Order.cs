using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMarket.Shared.DTOs;

namespace TopMarket.Shared.Entities
{
    public class Order
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Your Name is required.")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Your phone is required.")]
        public string CustomerPhone { get; set; }
        [Required(ErrorMessage = "Your email is required.")]
        public string CustomerEmail { get; set; }
        [Required(ErrorMessage = "Your Address is required.")]
        public string CustomerAddress { get; set; }
        public double Total { get; set; }
        public DateTime OrderDate { get; set; }
        public int PaymentType { get; set; }
        public int Status { get; set; }
    }
}
