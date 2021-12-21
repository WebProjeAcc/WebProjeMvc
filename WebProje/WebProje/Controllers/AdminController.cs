using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProje.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace WebProje.Controllers
{
    [Authorize("Admin")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Giris()
        {
            return View();

        }
        
      
        [HttpGet]
       
        public ActionResult UyeOl()
        {
            return View();
        }
    }
}
