using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class CustomerProduct
    {
        [Key]
        public int basicId { get; set; }
        public int CustomerId { get; set; }
        public Customer customer { get; set; }
    
        public int ProductId { get; set; }
        public Product product { get; set; }

        public double? Price { get; set; }


        public DateTime Order_date { get; set; }
    }
}
