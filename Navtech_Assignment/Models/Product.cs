using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Navtech_Assignment.Models

{
    public class Product
    {
        [Key]
        public string Feild { get; set; }
        public bool IsRequired { get; set; }
        public int MaxLength { get; set; }

        public string Source { get; set; }    
    }
}
