using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KGMIPiPK.Controllers
{
    [Route("api/[controller]")]
    public class GroupsController : Controller
    {
        private KGMIPiPKContext _context = new KGMIPiPKContext();
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Course_Group> Groups()
        {
            var groups = _context.Course_Group.FromSqlRaw("EXECUTE SP_SelectOfGroups").ToList();
            groups.Insert(0, new Course_Group { Code = 0, Group = "Группа ..." });
            return groups;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
