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
    public class ThemeController : ControllerBase
    {
        KGMIPiPKContext _context;
        public ThemeController(KGMIPiPKContext context)
        {
            _context = context;
        }
        // GET: api/Theme
        [HttpGet]
        public IEnumerable<Temy> Get()
        {
            var themes = _context.Temy.AsNoTracking().ToList();
            return themes;
        }

      
    }
}
