using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using KGMIPiPK.Models;
using System;

namespace KGMIPiPK.Controllers
{
    public class LexturesController : Controller
    {
        private readonly KGMIPiPKContext _context;

        public LexturesController(KGMIPiPKContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? group, int? teacher, int page = 1)
        {
            int pageSize = 10;

            //фильтрация
            IQueryable<Lextures> lextures = _context.Lextures
                .Include(l => l.GroupNavigation)
                .Include(l => l.GroupNavigation.CourseNavigation)
                .Include(l => l.TeacherNavigation)
                .Include(l => l.TemaNavigation)
                .Include(l => l.VidZanNavigation)
                .OrderByDescending(l => l.Day);

            if (group != null && group != 0)
            {
                lextures = lextures.Where(p => p.Group == group);
            }
            if (teacher != null && teacher != 0)
            {
                lextures = lextures.Where(p => p.Teacher == teacher);
            }

            // пагинация
            var count = await lextures.CountAsync();
            var items = await lextures.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();


            var groups = await _context.Course_Group.FromSqlRaw("EXECUTE SP_SelectOfGroups").ToListAsync();

            // формируем модель представления
            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = new PageViewModel(count, page, pageSize),
                FilterViewModel = new FilterViewModel(groups, group, _context.Teachers.ToList() , teacher),
                Lextures = items
            };
            return View(viewModel);
        }

        // GET: Lextures/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lextures = await _context.Lextures
                .Include(l => l.GroupNavigation)
                .Include(l => l.TeacherNavigation)
                .Include(l => l.TemaNavigation)
                .Include(l => l.VidZanNavigation)
                .FirstOrDefaultAsync(m => m.Nom == id);
            if (lextures == null)
            {
                return NotFound();
            }

            return View(lextures);
        }

        // GET: Lextures/Create
        public IActionResult Create()
        {
            ViewData["Group"] = new SelectList(_context.Groups, "Code", "Grup");
            ViewData["Teacher"] = new SelectList(_context.Teachers, "Nom", "Fio");
            ViewData["Tema"] = new SelectList(_context.Temy, "Nom", "Nom");
            ViewData["VidZan"] = new SelectList(_context.VidZan, "Nom", "Name");
            return View();
        }

        // POST: Lextures/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nom,Day,Group,Tema,Teacher,Hours,VidZan")] Lextures lextures)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lextures);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Group"] = new SelectList(_context.Groups, "Code", "Grup", lextures.Group);
            ViewData["Teacher"] = new SelectList(_context.Teachers, "Nom", "Fio", lextures.Teacher);
            ViewData["Tema"] = new SelectList(_context.Temy, "Nom", "Nom", lextures.Tema);
            ViewData["VidZan"] = new SelectList(_context.VidZan, "Nom", "Name", lextures.VidZan);
            return View(lextures);
        }

        // GET: Lextures/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lextures = await _context.Lextures.FindAsync(id);
            if (lextures == null)
            {
                return NotFound();
            }
            ViewData["Group"] = new SelectList(_context.Groups, "Code", "Grup", lextures.Group);
            ViewData["Teacher"] = new SelectList(_context.Teachers, "Nom", "Fio", lextures.Teacher);
            ViewData["Tema"] = new SelectList(_context.Temy, "Nom", "Nom", lextures.Tema);
            ViewData["VidZan"] = new SelectList(_context.VidZan, "Nom", "Name", lextures.VidZan);
            return View(lextures);
        }

        // POST: Lextures/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Nom,Day,Group,Tema,Teacher,Hours,VidZan")] Lextures lextures)
        {
            if (id != lextures.Nom)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lextures);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LexturesExists(lextures.Nom))
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
            ViewData["Group"] = new SelectList(_context.Groups, "Code", "Grup", lextures.Group);
            ViewData["Teacher"] = new SelectList(_context.Teachers, "Nom", "Fio", lextures.Teacher);
            ViewData["Tema"] = new SelectList(_context.Temy, "Nom", "Nom", lextures.Tema);
            ViewData["VidZan"] = new SelectList(_context.VidZan, "Nom", "Name", lextures.VidZan);
            return View(lextures);
        }

        // GET: Lextures/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lextures = await _context.Lextures
                .Include(l => l.GroupNavigation)
                .Include(l => l.TeacherNavigation)
                .Include(l => l.TemaNavigation)
                .Include(l => l.VidZanNavigation)
                .FirstOrDefaultAsync(m => m.Nom == id);
            if (lextures == null)
            {
                return NotFound();
            }

            return View(lextures);
        }

        // POST: Lextures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lextures = await _context.Lextures.FindAsync(id);
            _context.Lextures.Remove(lextures);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LexturesExists(int id)
        {
            return _context.Lextures.Any(e => e.Nom == id);
        }
    }
}