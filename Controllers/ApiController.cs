using KGMIPiPK.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace KGMIPiPK.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class ApiController : Controller
    {
        private readonly ILogger<ApiController> _logger;

        private KGMIPiPKContext _context;

        public ApiController(ILogger<ApiController> logger, KGMIPiPKContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet("groups/{id}")]
        public async Task<JsonResult> Groups(int id)
        {
            return Json(await _context.Groups.Where(t => t.Course == id).Select(u => new { id = u.Code, value = u.Grup }).AsNoTracking().ToListAsync());
        }

        [HttpGet("groups/students/{id}")]
        public async Task<JsonResult> GroupList(int id)
        {
            var students = await _context.Students.Where(e => e.Grup == id).Select(e => new
            {
                id = e.Number,
                name = e.Name,
                surname = e.Surname,
                lastname = e.Lastname,
                region = e.BirthPlace,
                district = e.DistrictNavigation.District,
                settlement = e.SettlementNavigation.FullName,
                lpu = e.UchregdenieNavigation.Name,
                post = e.PostNavigation.Post,
                head = e.HeadNavigation.Name
            }).AsNoTracking().ToListAsync();

            return Json(students);
        }

        [HttpGet("districts/{region}")]
        public async Task<IActionResult> Districts(string region)
        {
            var RegionId = await _context.Regions.Where(t => t.Region == region).AsNoTracking().FirstOrDefaultAsync();
            if (RegionId == null)
            {
                return NotFound();
            }

            return Ok(await _context.Districts.Where(t => t.Region == RegionId.Code).Select(u => new { id = u.Code, value = u.District }).AsNoTracking().ToListAsync());
        }

        [HttpGet("settlements/{id}")]
        public async Task<JsonResult> Settlements(int id)
        {
            return Json(await _context.Settlements.Where(t => t.Ter3Id == id).Select(u => new { id = u.Id, value = u.FullName }).AsNoTracking().ToListAsync());
        }

        [HttpGet("lpus/{id}")]
        public async Task<JsonResult> LPU(int id)
        {
            return Json(await _context.Lpu.Where(t => t.District == id).Select(u => new { id = u.Nom, value = u.Name }).AsNoTracking().ToListAsync());
        }


        //find course by group_id
        [HttpGet("course/{id}")]
        public async Task<JsonResult> Course(int id)
        {
            var group = await _context.Groups.FindAsync(id);

            return Json(await _context.Courses.Where(t => t.Nom == group.Course).Select(u => new { id = u.Nom, value = u.FullName }).FirstAsync());
        }

        [Obsolete]
        [HttpGet("student/search/{id}", Name = "search")]
        public async Task<JsonResult> Search(string id)
        {
            //var result = await _context.Names.FromSqlRaw("EXECUTE dbo.SP_FIOOfStudents_1").ToListAsync();
            //return Json(result.Where(e => EF.Functions.Like(e.FIO, "%" + id + "%")).Take(10));
            return Json(await _context.Names.FromSql("EXECUTE SP1_SearchStudentByFIO {0}", id).AsNoTracking().ToListAsync());
        }

       // api/student/{id}
       [HttpGet("student/{id}", Name = "getStudent")]
        public async Task<IActionResult> Student(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

        //api/student
        [HttpPost("student/")]
        public async Task<ActionResult<Students>> Post([FromBody]Students student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return Ok();
        }

        // PUT: api/student/5
        [HttpPut("student/{id}")]
        public async Task<ActionResult<Students>> EditStudent(int id, [FromBody]Students student)
        {
            _context.Entry(student).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/student/5
        [HttpDelete("student/{id}")]
        public async Task<ActionResult<Students>> Delete(int id)
        {
            var todoItem = await _context.Students.FindAsync(id);
            if (todoItem == null)
            {
                return NotFound();
            }

            _context.Students.Remove(todoItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        // PUT: api/lextures/prisutstvie/5
        [HttpPut("lextures/prisutstvie/{id}")]
        public async Task<ActionResult<PrisutstvieForLexture>> UpdatePrisutstvie(int id, [FromBody]PrisutstvieForLexture upd)
        {
            var prisutstvie = await _context.Prisutstvie.FindAsync(id);
            prisutstvie.Prisutstvie1 = upd.Prisutstvie;
            prisutstvie.Prim = upd.Prim;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Prisutstvie.Any(e => e.Nom == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private bool StudentsExists(int id)
        {
            return _context.Students.Any(e => e.Number == id);
        }
    }
}