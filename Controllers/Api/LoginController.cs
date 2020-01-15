using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using KGMIPiPK.Models;
using Lucene.Net.Support;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace KGMIPiPK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private readonly KGMIPiPKContext db;
        private IConfiguration _config;
        public LoginController(KGMIPiPKContext context,IConfiguration config)
        {
            db = context;
            _config = config;
        }
        // GET: api/ApiLogin
        
        [HttpGet]
        public IActionResult Login(String login,String psw)
        {
            LoginModel log
                = new LoginModel();
            log.Login = login;
            log.Password = psw;
            IActionResult response = Unauthorized();

            var user = AuthenticateUser(log);

            if(user != null)
            {
              
                var tokenStr = GenerateJSONWebToken(user);
                response = Ok(new { token = tokenStr, id = user.Id,department = user.Name});
            }
            return response;
        }

        private string GenerateJSONWebToken(Departments user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub,user.Login),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(
                issuer:_config["Jwt:Issuer"],
                audience: _config["Jwt:Issuer"],
                claims,
                expires:DateTime.Now.AddMinutes(120),
                signingCredentials:credentials
                );
            var encodingtoken = new JwtSecurityTokenHandler().WriteToken(token);
            return encodingtoken;
        }
        public string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }
        private Departments AuthenticateUser(LoginModel model)
        {
            Departments user1 =  db.Departments.FirstOrDefault(u => u.Login == model.Login && u.Password == model.Password);

            if (user1==null)
            {
                return null;
            }
            return user1;
        }
    }
}
