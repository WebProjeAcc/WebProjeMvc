using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProje.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=WebProje;integrated security=true;");
        }
        public DbSet<Product> Products { get; set; } 
        public DbSet<Categoryies> Category{ get; set; } 
       

    }
}
