using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorldSkillsSmartUniversityApi.Models.Domain;
using WorldSkillsSmartUniversityApi.Validators;

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
            await _dbContext.Rooms
                .AsNoTracking()
                .ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Room>> GetRoomAsync([EntityIdValidation(typeof(Room))] int id) =>
            await _dbContext.Rooms.FindAsync(id);
    }
}