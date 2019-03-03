using System.Collections.Generic;

namespace WorldSkillsSmartUniversityApi.Models.Domain
{
    public class Room : Entity
    {
        public string Name { get; set; }

        public string Photo { get; set; }
        
        public List<Device> Devices { get; set; } = new List<Device>();
    }
}