using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorldSkillsSmartUniversityApi.Models;
using WorldSkillsSmartUniversityApi.Models.Domain;

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
            await _dbContext.Macros.ToListAsync();

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var macro = await _dbContext.Macros.FindAsync(id);

            if (macro == null)
            {
                return NotFound(nameof(macro));
            }

            _dbContext.Remove(macro);

            await _dbContext.SaveChangesAsync();

            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> PostAsync(AddMacro macro)
        {
            var newMacro = new Macro
            {
                Name = macro.Name,
                Devices = macro.Devices
                    .Select(device => new MacroDevice
                    {
                        DeviceId = device.Id,
                        Value = device.Value
                    })
                    .ToList()
            };
            _dbContext.Macros.Add(newMacro);

            await _dbContext.SaveChangesAsync();

            return Ok(newMacro.Id);
        }
    }
}