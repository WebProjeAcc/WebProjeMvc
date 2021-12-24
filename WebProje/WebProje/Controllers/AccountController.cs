using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProje.Areas.Identity.Data;
using WebProje.Data;
using WebProje.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace WebProje.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {


            SignInManager<Users> SignInManager;
           
            
          UserManager <Users> UserManager;
         
            List<Users> Kullanicilar = _context.Users.ToList();
            return View(Kullanicilar);
        }
    }
}
