using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorldSkillsSmartUniversityApi.Models.Domain;

namespace WorldSkillsSmartUniversityApi.Controllers
{
    [ApiController]
    [Authorize]
    public class DevicesController : ControllerBase
    {
        private readonly SmartUniversityDbContext _dbContext;

        public DevicesController(SmartUniversityDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [Route("api/rooms/{roomId}/[controller]")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Device>>> GetDevicesAsync([FromRoute] int roomId) =>
            await _dbContext.Devices
                .Where(d => d.RoomId == roomId)
                .Include(d => d.Type)
                .AsNoTracking()
                .ToListAsync();
        
        [Route("api/[controller]/{id}")]
        [HttpGet]
        public async Task<ActionResult<Device>> GetDeviceAsync([FromRoute] int id) =>
            await _dbContext.Devices.FindAsync(id);
        
        [Route("api/[controller]/{id}")]
        [HttpPatch]
        public async Task<ActionResult> SetDeviceAsync([FromRoute] int id, [Required]string value)
        {
            var device = await _dbContext.Devices.FindAsync(id);

            if (device == null)
            {
                return NotFound();
            }
            
            //TODO add validation for value

            device.Value = value;

            await _dbContext.SaveChangesAsync();

            return Ok(new {id = device.Id, value = device.Value});
        }
    }
}