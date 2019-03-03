using System.Collections.Generic;

namespace WorldSkillsSmartUniversityApi.Models.Domain
{
    public class Macro : Entity
    {
        public string Name { get; set; }

        public List<MacroDevice> Devices { get; set; } = new List<MacroDevice>();
    }
}