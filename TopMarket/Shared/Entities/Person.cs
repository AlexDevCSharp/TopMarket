using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TopMarket.Shared.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Biography { get; set; }
        public string Picture { get; set; }
        //[Required]
        public DateTime? DateOfBirth { get; set; }
        public int StateId { get; set; }
        public State State { get; set; }
    }
}
