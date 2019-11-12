using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KGMIPiPK.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KGMIPiPK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        KGMIPiPKContext db = new KGMIPiPKContext();
        // GET: api/ApiLogin
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        

        // POST: api/ApiLogin
        [HttpPost]
        public Boolean Post([FromBody] String user)
        {
           // Departments user = db.Departments.FirstOrDefault(u => u.Login == model.Login && u.Password == model.Password);
            if (user != null)
            {
                return true;
            }else
            return false;
        }

       
    }
}
