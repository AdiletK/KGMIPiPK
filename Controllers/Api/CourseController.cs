using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KGMIPiPK.Controllers.Api
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        KGMIPiPKContext _context;

        public CourseController(KGMIPiPKContext context)
        {
            _context = context;
        }
        // GET: api/Course
        [HttpGet("by_id/{id}")]
        public IEnumerable<Courses> Courses(int id)
        {
            var courses = _context.Courses.Include(c => c.Groups).OrderByDescending(e => e.From)
                .Where(e => e.Dep == id)
                .AsNoTracking().ToList();
            courses.Insert(0, new Courses { Nom = 0, FullName = "Курс ..." });

            return courses;
        }

    }
}
