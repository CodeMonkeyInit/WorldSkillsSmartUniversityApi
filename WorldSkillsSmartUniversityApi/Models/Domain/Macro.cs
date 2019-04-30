using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace WorldSkillsSmartUniversityApi.Models.Domain
{
    public class Macro : Entity
    {
        public string Name { get; set; }
        
        public List<MacroDevice> Devices { get; set; } = new List<MacroDevice>();
    }
}