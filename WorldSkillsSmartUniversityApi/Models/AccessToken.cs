using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WorldSkillsSmartUniversityApi.Models
{
    public class AddMacro
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public List<DeviceValue> Devices { get; set; } = new List<DeviceValue>();
    }

    public class AccessToken
    {
        public string Token { get; set; }
    }
}