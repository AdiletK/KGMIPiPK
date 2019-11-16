using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KGMIPiPK;
using Microsoft.AspNetCore.Authorization;

namespace KGMIPiPK.Controllers.App
{
    [Authorize]
    public class CoursesController : Controller
    {
        private readonly KGMIPiPKContext _context;

        public CoursesController(KGMIPiPKContext context)
        {
            _context = context;
        }

        // GET: Courses
        public async Task<IActionResult> Index()
        {
            return View(await _context.Courses.Include(c => c.IstFinNavigation).OrderByDescending(e => e.From).AsNoTracking().ToListAsync());
        }

        // GET: Courses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courses = await _context.Courses
                .Include(c => c.IstFinNavigation)
                .FirstOrDefaultAsync(m => m.Nom == id);
            if (courses == null)
            {
                return NotFound();
            }

            ViewBag.init = await _context.Groups.Where(t => t.Course == id).Select(u => new { id = u.Code, value = u.Grup }).AsNoTracking().ToListAsync();

            return View(courses);
        }

        // GET: Courses/Create
        public IActionResult Create()
        {
            ViewData["IstFin"] = new SelectList(_context.IstFin, "Nom", "Name");
            return View();
        }

        // POST: Courses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nom,Name,From,To,FullName,Graduated,Plan,IstFin,Oplata")] Courses courses)
        {
            if (ModelState.IsValid)
            {
                _context.Add(courses);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IstFin"] = new SelectList(_context.IstFin, "Nom", "Name", courses.IstFin);
            return View(courses);
        }

        // GET: Courses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courses = await _context.Courses.FindAsync(id);
            if (courses == null)
            {
                return NotFound();
            }
            ViewData["IstFin"] = new SelectList(_context.IstFin, "Nom", "Name", courses.IstFin);
            return View(courses);
        }

        // POST: Courses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Nom,Name,From,To,FullName,Graduated,Plan,IstFin,Oplata")] Courses courses)
        {
            if (id != courses.Nom)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(courses);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CoursesExists(courses.Nom))
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
            ViewData["IstFin"] = new SelectList(_context.IstFin, "Nom", "Name", courses.IstFin);
            return View(courses);
        }

        // GET: Courses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courses = await _context.Courses
                .Include(c => c.IstFinNavigation)
                .FirstOrDefaultAsync(m => m.Nom == id);
            if (courses == null)
            {
                return NotFound();
            }

            return View(courses);
        }

        // POST: Courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var courses = await _context.Courses.FindAsync(id);
            _context.Courses.Remove(courses);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CoursesExists(int id)
        {
            return _context.Courses.Any(e => e.Nom == id);
        }
    }
}
