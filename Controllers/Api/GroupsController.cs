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
    public class GroupsController : Controller
    {
        private KGMIPiPKContext _context;

        public GroupsController(KGMIPiPKContext context)
        {
            _context = context;
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Course_Group> Groups()
        {
            var groups = _context.Course_Group.FromSqlRaw("EXECUTE SP_SelectOfGroups").ToList();
            groups.Insert(0, new Course_Group { Code = 0, Group = "Группа ..." });
            return groups;
        }

       
    }
}
