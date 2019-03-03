using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;
using WorldSkillsSmartUniversityApi.Models.Domain;

namespace WorldSkillsSmartUniversityApi.Validators
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ValidationBaseAttribute : ValidationAttribute
    {
        protected SmartUniversityDbContext DbContext;

        protected void Initialize(ValidationContext validationContext)
        {
            DbContext = validationContext.GetService<SmartUniversityDbContext>();
        }
    }
}