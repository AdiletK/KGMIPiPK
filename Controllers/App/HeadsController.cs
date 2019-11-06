using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KGMIPiPK;

namespace KGMIPiPK.Controllers.App
{
    public class HeadsController : Controller
    {
        private readonly KGMIPiPKContext _context;

        public HeadsController(KGMIPiPKContext context)
        {
            _context = context;
        }

        // GET: Heads
        public async Task<IActionResult> Index()
        {
            return View(await _context.Heads.ToListAsync());
        }

        // GET: Heads/Details/5
        public async Task<IActionResult> Details(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var heads = await _context.Heads
                .FirstOrDefaultAsync(m => m.Nom == id);
            if (heads == null)
            {
                return NotFound();
            }

            return View(heads);
        }

        // GET: Heads/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Heads/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nom,Name")] Heads heads)
        {
            if (ModelState.IsValid)
            {
                _context.Add(heads);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(heads);
        }

        // GET: Heads/Edit/5
        public async Task<IActionResult> Edit(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var heads = await _context.Heads.FindAsync(id);
            if (heads == null)
            {
                return NotFound();
            }
            return View(heads);
        }

        // POST: Heads/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(byte id, [Bind("Nom,Name")] Heads heads)
        {
            if (id != heads.Nom)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(heads);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HeadsExists(heads.Nom))
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
            return View(heads);
        }

        // GET: Heads/Delete/5
        public async Task<IActionResult> Delete(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var heads = await _context.Heads
                .FirstOrDefaultAsync(m => m.Nom == id);
            if (heads == null)
            {
                return NotFound();
            }

            return View(heads);
        }

        // POST: Heads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(byte id)
        {
            var heads = await _context.Heads.FindAsync(id);
            _context.Heads.Remove(heads);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HeadsExists(byte id)
        {
            return _context.Heads.Any(e => e.Nom == id);
        }
    }
}
