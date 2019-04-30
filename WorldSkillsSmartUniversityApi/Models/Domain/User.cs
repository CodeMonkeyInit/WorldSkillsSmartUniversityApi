using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WorldSkillsSmartUniversityApi.Models.Domain
{
    public class User
    {
        [Required]
        [Key]
        public string Username { get; set; }

        public string Password { get; set; }

        public List<Room> Rooms { get; set; } = new List<Room>();

        public List<Device> Devices { get; set; } = new List<Device>();

        public List<Macro> Macros { get; set; } = new List<Macro>();
    }
}