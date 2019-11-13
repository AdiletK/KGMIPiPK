using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KGMIPiPK;
using Microsoft.AspNetCore.Authorization;

namespace KGMIPiPK.Controllers.DB
{
    [Authorize]
    public class TopicsController : Controller
    {
        private readonly KGMIPiPKContext _context;

        public TopicsController(KGMIPiPKContext context)
        {
            _context = context;
        }

        // GET: Temies
        public async Task<IActionResult> Index()
        {
            return View(await _context.Temy.ToListAsync());
        }

        // GET: Temies/Details/5
        public async Task<IActionResult> Details(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var temy = await _context.Temy
                .FirstOrDefaultAsync(m => m.Nom == id);
            if (temy == null)
            {
                return NotFound();
            }

            return View(temy);
        }

        // GET: Temies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Temies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nom,Name")] Temy temy)
        {
            if (ModelState.IsValid)
            {
                _context.Add(temy);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(temy);
        }

        // GET: Temies/Edit/5
        public async Task<IActionResult> Edit(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var temy = await _context.Temy.FindAsync(id);
            if (temy == null)
            {
                return NotFound();
            }
            return View(temy);
        }

        // POST: Temies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(short id, [Bind("Nom,Name")] Temy temy)
        {
            if (id != temy.Nom)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(temy);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TemyExists(temy.Nom))
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
            return View(temy);
        }

        // GET: Temies/Delete/5
        public async Task<IActionResult> Delete(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var temy = await _context.Temy
                .FirstOrDefaultAsync(m => m.Nom == id);
            if (temy == null)
            {
                return NotFound();
            }

            return View(temy);
        }

        // POST: Temies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(short id)
        {
            var temy = await _context.Temy.FindAsync(id);
            _context.Temy.Remove(temy);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TemyExists(short id)
        {
            return _context.Temy.Any(e => e.Nom == id);
        }
    }
}
