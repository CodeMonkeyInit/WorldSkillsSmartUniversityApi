using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Twitter;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using WorldSkillsSmartUniversityApi.Models;
using WorldSkillsSmartUniversityApi.Models.Domain;
using AccessToken = WorldSkillsSmartUniversityApi.Models.AccessToken;

namespace WorldSkillsSmartUniversityApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly SmartUniversityDbContext _dbContext;

        public LoginController(IConfiguration configuration, SmartUniversityDbContext dbContext)
        {
            _configuration = configuration;
            _dbContext = dbContext;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult<AccessToken>> Login([FromBody] LoginData loginData)
        {
            var user = await AuthenticateUserAsync(loginData);

            if (user == null)
            {
                return Unauthorized();
            }

            return GenerateJsonWebToken(user);
        }

        private AccessToken GenerateJsonWebToken(User userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_configuration["Jwt:Issuer"],
                _configuration["Jwt:Issuer"],
                null,
                expires: DateTime.Now.AddHours(24),
                signingCredentials: credentials);

            return new AccessToken {Token = new JwtSecurityTokenHandler().WriteToken(token)};
        }


        private Task<User> AuthenticateUserAsync(LoginData login)
        {
            return _dbContext.Users
                .FirstOrDefaultAsync(user => 
                    user.Username == login.Login && user.Password == login.Password);
        }
    }
}