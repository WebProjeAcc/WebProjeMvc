using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProje.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }

        public double ProductPrice{ get; set; }
        
        public string ImageUrl { get; set; }

        public string Description { get; set; }

        public int ProductStock { get; set; }
        public int CategoryID { get; set; }
        public virtual Categoryies  Category { get; set; }

    }
}
