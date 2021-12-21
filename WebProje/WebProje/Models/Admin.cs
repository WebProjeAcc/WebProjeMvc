using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProje.Models
{
    public class Admin
    {
       
        [StringLength(20)]
        public string Username { get; set; }
        
    
      
      

    }
}
