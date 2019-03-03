using System.ComponentModel.DataAnnotations;

namespace WorldSkillsSmartUniversityApi.Models
{
    public class LoginData
    {
        [Required]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }
    }
}