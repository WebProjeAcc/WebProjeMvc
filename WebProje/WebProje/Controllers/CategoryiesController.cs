using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebProje.Areas.Identity.Data;
using WebProje.Models;

namespace WebProje.Controllers
{
    public class CategoryiesController : Controller
    {
        private readonly DatabaseContext _context;

        public CategoryiesController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: Categoryies
        public async Task<IActionResult> Index()
        {
            return View(await _context.Categoryies.ToListAsync());
        }

        // GET: Categoryies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoryies = await _context.Categoryies
                .FirstOrDefaultAsync(m => m.CategoryID == id);
            if (categoryies == null)
            {
                return NotFound();
            }

            return View(categoryies);
        }

        // GET: Categoryies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categoryies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CategoryID,CategoryName")] Categoryies categoryies)
        {
            if (ModelState.IsValid)
            {
                _context.Add(categoryies);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(categoryies);
        }

        // GET: Categoryies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoryies = await _context.Categoryies.FindAsync(id);
            if (categoryies == null)
            {
                return NotFound();
            }
            return View(categoryies);
        }

        // POST: Categoryies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CategoryID,CategoryName")] Categoryies categoryies)
        {
            if (id != categoryies.CategoryID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(categoryies);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryiesExists(categoryies.CategoryID))
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
            return View(categoryies);
        }

        // GET: Categoryies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoryies = await _context.Categoryies
                .FirstOrDefaultAsync(m => m.CategoryID == id);
            if (categoryies == null)
            {
                return NotFound();
            }

            return View(categoryies);
        }

        // POST: Categoryies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var categoryies = await _context.Categoryies.FindAsync(id);
            _context.Categoryies.Remove(categoryies);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryiesExists(int id)
        {
            return _context.Categoryies.Any(e => e.CategoryID == id);
        }
    }
}
