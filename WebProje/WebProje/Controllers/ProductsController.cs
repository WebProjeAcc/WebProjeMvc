using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebProje.Areas.Identity.Data;
using WebProje.Models;

namespace WebProje.Controllers
{
    public class ProductsController : Controller
    {
        private readonly DatabaseContext _context;

        public ProductsController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            var databaseContext = _context.Products.Include(p => p.Category);
            return View(await databaseContext.ToListAsync());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            List<SelectListItem> values = (from x in _context.Categoryies.ToList()
                                           select new SelectListItem
                                           {
                                               Text=x.CategoryName,
                                               Value=x.CategoryID.ToString()

                                           }).ToList();
            ViewData["CategoryID"] = new SelectList(_context.Categoryies, "CategoryID", "CategoryID");
            ViewBag.v1 = values;
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductID,ProductName,ProductPrice,ImageUrl,Description,ProductStock,CategoryID")] AddProduct p)
        {
            Product product = new Product();
            if(p.ImageUrl != null)
            {
                var extension = Path.GetExtension(p.ImageUrl.FileName);
                var newName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/images/", newName);
                var stream = new FileStream(location, FileMode.Create);
                p.ImageUrl.CopyTo(stream);
                product.ImageUrl = newName;
            }
            
            product.ProductName = p.ProductName;
            product.ProductPrice = p.ProductPrice;
            product.ProductStock = p.ProductStock;
            product.ProductID = p.ProductID;
            product.Description = p.Description;
            product.CategoryID = p.CategoryID;

            



            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryID"] = new SelectList(_context.Categoryies, "CategoryID", "CategoryID", product.CategoryID);
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            List<SelectListItem> values = (from x in _context.Categoryies.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()

                                           }).ToList();
            ViewData["CategoryID"] = new SelectList(_context.Categoryies, "CategoryID", "CategoryID");
            ViewBag.v1 = values;

            ViewData["CategoryID"] = new SelectList(_context.Categoryies, "CategoryID", "CategoryID", product.CategoryID);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductID,ProductName,ProductPrice,ProductStock,CategoryID")] Product product)
        {
            if (id != product.ProductID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryID"] = new SelectList(_context.Categoryies, "CategoryID", "CategoryID", product.CategoryID);
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Satis(int id, [Bind("ProductID,ProductName,ProductPrice,ProductStock,CategoryID")] Product productView)
        {

            Product p1 = new Product();
            if (id != productView.ProductID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                p1 = _context.Products.Find(productView.ProductID);
                p1.ProductStock = p1.ProductStock - productView.ProductStock;
                try
                {
                    _context.Update(p1);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(p1.ProductID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index", "Home");
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Satis(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            List<SelectListItem> values = (from x in _context.Categoryies.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()

                                           }).ToList();
            ViewData["CategoryID"] = new SelectList(_context.Categoryies, "CategoryID", "CategoryID");
            ViewBag.v1 = values;

            ViewData["CategoryID"] = new SelectList(_context.Categoryies, "CategoryID", "CategoryID", product.CategoryID);
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductID == id);
        }

        public IActionResult Barkod()
        {

            List<SelectListItem> values = (from x in _context.Products.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.ProductName,
                                               Value = x.ProductID.ToString()

                                           }).ToList();
            ViewData["ProductId"] = new SelectList(_context.Categoryies, "ProductID", "ProductID");
            ViewBag.v2 = values;
            return View();
        }
    }
}
