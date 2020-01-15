using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KGMIPiPK.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    public class TeachersController : Controller
    {
        private KGMIPiPKContext _context;
        public TeachersController(KGMIPiPKContext db)
        {
            _context = db;
        }
        // GET: api/<controller>
        [HttpGet("{id}")]
        public IEnumerable<Teachers> Get(int id)
        {
            var teachers = _context.Teachers
                .Include(t => t.DepartmentNavigation)
                .Include(t => t.FacultyNavigation)
                .Where(e => e.Department == id)
                .AsNoTracking().ToList();
            teachers.Insert(0, new Teachers { Fio = "Преподаватель ...", Nom = 0 });

            return teachers;
        }

    }
}
