using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KGMIPiPK.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class LectionsController : ControllerBase
    {
        KGMIPiPKContext _context = new KGMIPiPKContext();
        // GET: api/Lection
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Lection/5
        [HttpGet("{group}/{teacher}", Name = "Get")]
        public IEnumerable<Lextures> Get(int? group, int? teacher)
        {

            IQueryable<Lextures> lextures = _context.Lextures
                .Include(l => l.GroupNavigation)
                .Include(l => l.GroupNavigation.CourseNavigation)
                .Include(l => l.TeacherNavigation)
                .Include(l => l.TemaNavigation)
                .Include(l => l.VidZanNavigation)
                .OrderByDescending(l => l.Day);


            if (group != 0)
            {
                lextures = lextures.Where(p => p.Group == group);
            }
            if (teacher != 0)
            {
                lextures = lextures.Where(p => p.Teacher == teacher);
            }

            return lextures;
        }

        // POST: api/Lection
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Lection/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
