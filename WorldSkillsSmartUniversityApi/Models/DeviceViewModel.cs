using System.ComponentModel.DataAnnotations;
using WorldSkillsSmartUniversityApi.Models.Domain;
using WorldSkillsSmartUniversityApi.Validators;

namespace WorldSkillsSmartUniversityApi.Models
{
    public class DeviceViewModel
    {
        [Required]
        [EntityIdValidation(typeof(Device))]
        public int? Id { get; set; }
    }
}