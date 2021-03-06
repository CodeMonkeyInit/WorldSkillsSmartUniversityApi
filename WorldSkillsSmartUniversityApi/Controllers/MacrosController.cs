using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorldSkillsSmartUniversityApi.Models;
using WorldSkillsSmartUniversityApi.Models.Domain;
using WorldSkillsSmartUniversityApi.Validators;

namespace WorldSkillsSmartUniversityApi.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class MacrosController : ControllerBase
    {
        private readonly SmartUniversityDbContext _dbContext;

        public MacrosController(SmartUniversityDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Macro>>> GetAsync() =>
            await _dbContext.GetMacrosAsync(User.Identity.Name)
                .Include(macro => macro.Devices)
                .ThenInclude(device => device.Device)
                .ToListAsync();


        [HttpPatch]
        [Route("{id}")]
        public async Task<ActionResult> ActivateAsync(int id)
        {
            var macro = await _dbContext.GetMacroAsync(id, User.Identity.Name);

            if (macro == null)
            {
                return NotFound(new {Success = false});
            }

            foreach (var macroDevice in macro.Devices)
            {
                macroDevice.Device.Value = macroDevice.Value;

                await _dbContext.SaveChangesAsync();
            }
            
            return Ok(new {Success = true});
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> Delete([EntityIdValidation(typeof(Macro))]int id)
        {
            Macro removingMacro = await _dbContext.GetMacrosAsync(User.Identity.Name)
                .FirstOrDefaultAsync(macro => macro.Id == id);

            _dbContext.Remove(removingMacro);

            await _dbContext.SaveChangesAsync();

            return Ok(new {Success = true});
        }

        [HttpPost]
        public async Task<ActionResult<Macro>> PostAsync(AddMacro macro)
        {
            var newMacro = new Macro
            {
                Name = macro.Name,
                UserId = User.Identity.Name,
                Devices = macro.Devices
                    .Select(device => new MacroDevice
                    {
                        DeviceId = device.Id.Value,
                        Value = device.Value
                    })
                    .ToList()
            };
            _dbContext.Macros.Add(newMacro);

            await _dbContext.SaveChangesAsync();

            return Ok(newMacro);
        }
    }
}