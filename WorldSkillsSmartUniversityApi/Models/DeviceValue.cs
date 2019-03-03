using System.ComponentModel.DataAnnotations;
using WorldSkillsSmartUniversityApi.Models.Domain;
using WorldSkillsSmartUniversityApi.Validators;

namespace WorldSkillsSmartUniversityApi.Models
{
    public class DeviceValue
    {
        [Required]
        [EntityIdValidation(typeof(Device))]
        public int Id { get; set; }

        [Required]
        public string Value { get; set; }
    }
}