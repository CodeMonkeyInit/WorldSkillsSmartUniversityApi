using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorldSkillsSmartUniversityApi.Models;
using WorldSkillsSmartUniversityApi.Models.Domain;
using WorldSkillsSmartUniversityApi.Validators;

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
        public async Task<ActionResult<IEnumerable<Device>>> GetDevicesAsync(
            [FromRoute] [EntityIdValidation(typeof(Room))]
            int roomId) =>
            await _dbContext.GetDevicesInRoomAsync(roomId);

        [Route("api/[controller]/{id}")]
        [HttpGet]
        public async Task<ActionResult<Device>> GetDeviceAsync([FromRoute] [EntityIdValidation(typeof(Device))]
            int id) =>
            await _dbContext.GetDeviceAsync(id);

        [Route("api/[controller]")]
        [HttpPatch]
        public async Task<ActionResult> SetDeviceAsync([FromBody] DeviceValue setDevice)
        {
            var device = await _dbContext.Devices.FindAsync(setDevice.Id);

            device.Value = setDevice.Value;

            await _dbContext.SaveChangesAsync();

            return Ok(new {id = device.Id, value = device.Value});
        }
    }
}