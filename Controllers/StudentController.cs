﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using KGMIPiPK.Models;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;

namespace KGMIPiPK.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class StudentController : Controller
    {
        private readonly ILogger<StudentController> _logger;

        private KGMIPiPKContext _context;

        public StudentController(ILogger<StudentController> logger, KGMIPiPKContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet("groups/{id}")]
        public async Task<JsonResult> Groups(int id)
        {
            return Json(await _context.Groups.Where(t => t.Code == id).Select(u => new { id = u.Code, value = u.Grup }).ToListAsync() );
        }

        [HttpGet("districts/{id}")]
        public async Task<JsonResult> Districts(string id)
        {
            var RegionId = await _context.Regions.Where(t => t.Region == id).FirstAsync();
            return Json( await _context.Districts.Where(t => t.Region == RegionId.Code).Select(u => new { id = u.Code, value = u.District }).ToListAsync() );
        }

        [HttpGet("settlements/{id}")]
        public async Task<JsonResult> Settlements(int id)
        {
            return Json(await _context.Settlements.Where(t => t.Ter3Id == id).Select(u => new { id = u.Id, value = u.FullName }).ToListAsync());
        }

        [HttpGet("lpus/{id}")]
        public async Task<JsonResult> LPU(int id)
        {
            return Json(await _context.Lpu.Where(t => t.District == id).Select(u => new { id = u.Nom, value = u.Name }).ToListAsync());
        }

        [Obsolete]
        [HttpGet("search/{id}", Name = "search")]
        public async Task<JsonResult> Search(string id)
        {
            //var students = _context.Students.Where(s => s.Surname.Contains(id)).Take(30).ToList();
            return Json(await _context.Names.FromSql("EXECUTE SP1_SearchStudentByFIO {0}", id).ToListAsync());
        }

        // api/student/{id}
        [HttpGet("{id}", Name = "getStudent")]
        public async Task<JsonResult> Student(int id)
        {
            return Json(await _context.Students.FindAsync(id));
        }


        //api/student
        [HttpPost]
        public async Task<ActionResult<Students>>  Post([FromBody]Students student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return Ok();
        }


        // PUT: api/student/5
        [HttpPut("{id}")]
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
        [HttpDelete("{id}")]
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