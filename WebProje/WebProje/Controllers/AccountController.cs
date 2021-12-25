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
using System.Net;
using Microsoft.AspNetCore.Authorization;

namespace WebProje.Controllers
{
    [Authorize]
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


            UserManager<Users> UserManager;
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);


            var LogİnUser = _context.Users.Where(i => i.Id == userId).FirstOrDefault();
            
           
            ViewBag.UserName = LogİnUser.UserName.ToString();
            ViewBag.Name = LogİnUser.Name.ToString();
            ViewBag.LastName = LogİnUser.LastName.ToString();
            ViewBag.Phone = LogİnUser.Phone.ToString();
            List<Users> Kullanicilar = _context.Users.ToList();
            return View(Kullanicilar);
        }
        public IActionResult Logout()
        {


            return View();
        }

        public async Task<IActionResult> Delete(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = _context.Users.Find(id);
            _context.Users.Remove(user);
            _context.SaveChanges();
         
            return RedirectToAction("Logout","Account");
        }
        [HttpPost]
        public async Task<IActionResult> Update(Users user)
        {
            if (user.Id== null)
            {
                return NotFound();
            }
            //var LogİnUser = _context.Users.Where(i => i.Id == user.Id).FirstOrDefault();
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);


            var LogİnUser = _context.Users.Where(i => i.Id == userId).FirstOrDefault();


            ViewBag.UserName = LogİnUser.UserName.ToString();
            ViewBag.Name = LogİnUser.Name.ToString();
            ViewBag.LastName = LogİnUser.LastName.ToString();
            ViewBag.Phone = LogİnUser.Phone.ToString();



            Users newuser = _context.Users.Find(user.Id.ToString());
            newuser.Name = user.Name;
            newuser.LastName = user.LastName;
            newuser.UserName = user.UserName;
            newuser.Phone = user.Phone;

            _context.Users.Update(newuser);

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        /*   [HttpPost, ActionName("Delete")]
           [ValidateAntiForgeryToken]
           public async Task<IActionResult> DeleteConfirmed(int id)
           {
               var user = await _context.Products.FindAsync(id);
               _context.Products.Remove(user);
               await _context.SaveChangesAsync();
               return RedirectToAction(nameof(Index));
           }*/
        /* [HttpPost]
         [ValidateAntiForgeryToken]
         public async Task<IActionResult> Update(int id, [Bind("Name,,LastName,phone,name")] Users user)
         {
           

            SignInManager<Users> SignInManager;


            UserManager<Users> UserManager;
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);


            var LogİnUser = _context.Users.Where(i => i.Id == userId).FirstOrDefault();
            if (id.ToString() !=LogİnUser.Id.ToString())
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                 
                }
                return RedirectToAction(nameof(Index));
            }

           
            return RedirectToAction("Index");
           
          

     }*/
    }
}
