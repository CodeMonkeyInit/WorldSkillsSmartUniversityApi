using System.ComponentModel.DataAnnotations;
using WorldSkillsSmartUniversityApi.Validators;

namespace WorldSkillsSmartUniversityApi.Models
{
    public class DeviceValue : DeviceViewModel
    {
        [Required]
        [DeviceValueValidation]
        public string Value { get; set; }
    }
}