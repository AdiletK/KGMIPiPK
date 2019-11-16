using KGMIPiPK.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace KGMIPiPK.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private KGMIPiPKContext db;

        public HomeController(ILogger<HomeController> logger, KGMIPiPKContext context)
        {
            _logger = logger;
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            // include our data to view data
            ViewBag.init = new 
            {
                course = await db.Courses.OrderByDescending(e => e.From).Select(u => new { id = u.Nom, value = u.FullName }).AsNoTracking().ToListAsync(),
                sex = await db.Sex.Select(u => new { id = u.Code, value = u.Sex1 }).AsNoTracking().ToListAsync(),
                nationality = await db.GlbPNation.Select(u => new { id = u.Id, value = u.FullName }).AsNoTracking().ToListAsync(),
                region = await db.Regions.Select(u => new { id = u.Code, value = u.Region }).AsNoTracking().ToListAsync(),
                post = await db.Posts.Select(u => new { id = u.Nom, value = u.Post }).AsNoTracking().ToListAsync(),
                head = await db.Heads.Select(u => new { id = u.Nom, value = u.Name }).AsNoTracking().ToListAsync(),
                education = await db.GlbSStaffType.Select(u => new { id = u.Code, value = u.FullName }).AsNoTracking().ToListAsync()
            };
            return View();
        }


        [Route("error/404")]
        public IActionResult Error404()
        {
            return View("404",new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("error/{code:int}")]
        public IActionResult Error(int code)
        {
            // handle different codes or just return the default error view
            return View("Error", new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}