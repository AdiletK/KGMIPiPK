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
    public class LectionsController : ControllerBase
    {
        KGMIPiPKContext _context;
        public LectionsController(KGMIPiPKContext db)
        {
            _context = db;
        }

        // GET: api/Lection/5
        [HttpGet("{group}/{teacher}", Name = "lection")]
        public IEnumerable<Lextures> Get(int? group, int? teacher)
        {

            IQueryable<Lextures> lextures = _context.Lextures
                .Include(l => l.GroupNavigation)
                .Include(l => l.GroupNavigation.CourseNavigation)
                .Include(l => l.TeacherNavigation)
                .Include(l => l.TemaNavigation)
                .Include(l => l.VidZanNavigation)
                .OrderByDescending(l => l.Day).AsNoTracking();


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

        [HttpGet("{lectionId}", Name = "students")]
        public IEnumerable<PrisutstvieForLexture> Get(int? lectionId)
        {
            if (lectionId == null)
            {
                return null;
            }
            //prisutstvie
            var students =  _context.PrisutstvieForLexture.FromSqlRaw("EXECUTE SP1_PrisutstvieForLexture {0} ", lectionId).ToList();

            return students;
        }

        [HttpPost]
        public Task<int> Post([FromBody] Lextures lextures)
        {
            var id = _context.SP_InsertToLexturesAsync(lextures);
            return id;
    
        }

        [HttpPut("{id}")]
        public async Task<Boolean> Put(int id, [FromBody]PrisutstvieForLexture upd)
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
               // if (!_context.Prisutstvie.Any(e => e.Nom == id))
              //  {
                    return false;
                
               
            }

            return true;
        }
    }
}
