using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorldSkillsSmartUniversityApi.Models.Domain;

namespace WorldSkillsSmartUniversityApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class RoomsController : ControllerBase
    {
        private readonly SmartUniversityDbContext _dbContext;

        public RoomsController(SmartUniversityDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Room>>> GetRoomsAsync() =>
            await _dbContext.Rooms.AsNoTracking().ToListAsync();
    }
}