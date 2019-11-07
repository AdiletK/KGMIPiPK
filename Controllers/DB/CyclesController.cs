using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KGMIPiPK;

namespace KGMIPiPK.Controllers.DB
{
    public class CyclesController : Controller
    {
        private readonly KGMIPiPKContext _context;

        public CyclesController(KGMIPiPKContext context)
        {
            _context = context;
        }

        // GET: Tsiklies
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tsikly.ToListAsync());
        }

        // GET: Tsiklies/Details/5
        public async Task<IActionResult> Details(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tsikly = await _context.Tsikly
                .FirstOrDefaultAsync(m => m.Nom == id);
            if (tsikly == null)
            {
                return NotFound();
            }

            return View(tsikly);
        }

        // GET: Tsiklies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tsiklies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nom,Name")] Tsikly tsikly)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tsikly);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tsikly);
        }

        // GET: Tsiklies/Edit/5
        public async Task<IActionResult> Edit(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tsikly = await _context.Tsikly.FindAsync(id);
            if (tsikly == null)
            {
                return NotFound();
            }
            return View(tsikly);
        }

        // POST: Tsiklies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(byte id, [Bind("Nom,Name")] Tsikly tsikly)
        {
            if (id != tsikly.Nom)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tsikly);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TsiklyExists(tsikly.Nom))
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
            return View(tsikly);
        }

        // GET: Tsiklies/Delete/5
        public async Task<IActionResult> Delete(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tsikly = await _context.Tsikly
                .FirstOrDefaultAsync(m => m.Nom == id);
            if (tsikly == null)
            {
                return NotFound();
            }

            return View(tsikly);
        }

        // POST: Tsiklies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(byte id)
        {
            var tsikly = await _context.Tsikly.FindAsync(id);
            _context.Tsikly.Remove(tsikly);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TsiklyExists(byte id)
        {
            return _context.Tsikly.Any(e => e.Nom == id);
        }
    }
}
