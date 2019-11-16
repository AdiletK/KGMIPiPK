using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KGMIPiPK.Controllers
{
    [Authorize]
    public class GroupListsController : Controller
    {
        private readonly KGMIPiPKContext _context;

        public GroupListsController(KGMIPiPKContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.init = await _context.Courses.OrderByDescending(e => e.From).Select(e => new { id = e.Nom, value = e.FullName }).ToListAsync();

            return View();
        }

    }
}