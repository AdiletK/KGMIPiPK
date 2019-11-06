using KGMIPiPK.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;

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

        public IActionResult Index()
        {
            var course = db.Courses.Select(u => new { id = u.Nom, value = u.FullName }).ToList();

            var sex = db.Sex.Select(u => new { id = u.Code, value = u.Sex1 }).ToList();
            var nationality = db.GlbPNation.Select(u => new { id = u.Id, value = u.FullName }).ToList();
            var region = db.Regions.Select(u => new { id = u.Code, value = u.Region }).ToList();

            var post = db.Posts.Select(u => new { id = u.Nom, value = u.Post }).ToList();
            var head = db.Heads.Select(u => new { id = u.Nom, value = u.Name }).ToList();
            var education = db.GlbSStaffType.Select(u => new { id = u.Code, value = u.FullName }).ToList();

            var data = new
            {
                course,
                sex,
                nationality,
                region,
                post,
                head,
                education,
            };

            ViewBag.init = data;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}