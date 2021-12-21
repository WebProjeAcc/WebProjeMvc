using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProje.Models
{
    public class Categoryies
    {
        [Key]
        public int CategoryID { get; set; }
        public String CategoryName { get; set; }
  
        public List<Product> Products { get; set; }
    }
}
