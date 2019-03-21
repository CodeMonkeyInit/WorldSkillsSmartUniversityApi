using System.Collections.Generic;
using Newtonsoft.Json;

namespace WorldSkillsSmartUniversityApi.Models.Domain
{
    public class Room : Entity
    {
        public string Name { get; set; }

        public string Photo { get; set; }
        
        [JsonIgnore]
        public List<Device> Devices { get; set; } = new List<Device>();
    }
}