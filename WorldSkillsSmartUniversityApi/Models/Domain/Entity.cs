using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace WorldSkillsSmartUniversityApi.Models.Domain
{
    public class Entity
    {
        public int Id { get; set; }

        [Required]
        [JsonIgnore]
        public string UserId { get; set; }

        [JsonIgnore]
        public User User { get; set; }
    }
}