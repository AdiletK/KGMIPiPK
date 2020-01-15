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
    public class TypeOfLessonController : ControllerBase
    {
        KGMIPiPKContext _context ;
        public TypeOfLessonController(KGMIPiPKContext context)
        {
            _context = context;
        }
        // GET: api/TypeOfLesson
        [HttpGet]
        public IEnumerable<VidZan> Get()
        {
            var types = _context.VidZan.AsNoTracking().ToList();
            return types;
        }

        
    }
}
