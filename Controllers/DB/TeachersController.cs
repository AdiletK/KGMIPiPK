using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KGMIPiPK.Models;
using Microsoft.AspNetCore.Authorization;

namespace KGMIPiPK.Controllers.DB
{
    [Authorize]
    public class TeachersController : Controller
    {
        private readonly KGMIPiPKContext _context;

        public TeachersController(KGMIPiPKContext context)
        {
            _context = context;
        }

        // GET: Teachers
        [Route("Teachers/{page:int=1}")]
        public async Task<IActionResult> Index(int page)
        {
            if (page < 1)
            {
                return NotFound();
            }
            int pageSize = 15;
            var source = _context.Teachers.Include(t => t.DepartmentNavigation).Include(t => t.FacultyNavigation);

            var count = await source.CountAsync();
            var items = await source.Skip((page - 1) * pageSize).Take(pageSize).AsNoTracking().ToListAsync();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            if (pageViewModel.TotalPages < page)
            {
                return NotFound();
            }

            TeacherViewModel viewModel = new TeacherViewModel
            {
                PageViewModel = pageViewModel,
                Teachers = items
            };

            return View(viewModel);
        }

        // GET: Teachers/Details/5
        public async Task<IActionResult> Details(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teachers = await _context.Teachers
                .Include(t => t.DepartmentNavigation)
                .Include(t => t.FacultyNavigation)
                .FirstOrDefaultAsync(m => m.Nom == id);
            if (teachers == null)
            {
                return NotFound();
            }

            return View(teachers);
        }

        // GET: Teachers/Create
        public IActionResult Create()
        {
            ViewData["Department"] = new SelectList(_context.Departments, "Id", "Name");
            ViewData["Faculty"] = new SelectList(_context.Faculties, "Id", "FullName");
            return View();
        }

        // POST: Teachers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nom,Fio,Faculty,Department,Telefon,Prim")] Teachers teachers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(teachers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Department"] = new SelectList(_context.Departments, "Id", "Name", teachers.Department);
            ViewData["Faculty"] = new SelectList(_context.Faculties, "Id", "FullName", teachers.Faculty);
            return View(teachers);
        }

        // GET: Teachers/Edit/5
        public async Task<IActionResult> Edit(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teachers = await _context.Teachers.FindAsync(id);
            if (teachers == null)
            {
                return NotFound();
            }
            ViewData["Department"] = new SelectList(_context.Departments, "Id", "Name", teachers.Department);
            ViewData["Faculty"] = new SelectList(_context.Faculties, "Id", "FullName", teachers.Faculty);
            return View(teachers);
        }

        // POST: Teachers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(short id, [Bind("Nom,Fio,Faculty,Department,Telefon,Prim")] Teachers teachers)
        {
            if (id != teachers.Nom)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(teachers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeachersExists(teachers.Nom))
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
            ViewData["Department"] = new SelectList(_context.Departments, "Id", "Name", teachers.Department);
            ViewData["Faculty"] = new SelectList(_context.Faculties, "Id", "FullName", teachers.Faculty);
            return View(teachers);
        }

        // GET: Teachers/Delete/5
        public async Task<IActionResult> Delete(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teachers = await _context.Teachers
                .Include(t => t.DepartmentNavigation)
                .Include(t => t.FacultyNavigation)
                .FirstOrDefaultAsync(m => m.Nom == id);
            if (teachers == null)
            {
                return NotFound();
            }

            return View(teachers);
        }

        // POST: Teachers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(short id)
        {
            var teachers = await _context.Teachers.FindAsync(id);
            _context.Teachers.Remove(teachers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeachersExists(short id)
        {
            return _context.Teachers.Any(e => e.Nom == id);
        }
    }
}
