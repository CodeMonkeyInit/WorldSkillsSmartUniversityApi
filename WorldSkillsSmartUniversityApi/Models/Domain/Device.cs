using System.Collections.Generic;

namespace WorldSkillsSmartUniversityApi.Models.Domain
{
    public class Device : Entity
    {
        public int RoomId { get; set; }

        public Room Room { get; set; }

        public int TypeId { get; set; }
        
        public DeviceType Type { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        public string TypeName => Type.Name;

        public List<MacroDevice> Macros { get; set; }
    }
}