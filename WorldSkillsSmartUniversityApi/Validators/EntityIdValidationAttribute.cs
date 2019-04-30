using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using WorldSkillsSmartUniversityApi.Models.Domain;

namespace WorldSkillsSmartUniversityApi.Validators
{
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property)]
    public class EntityIdValidationAttribute : ValidationBaseAttribute
    {
        private readonly Type _entityType;

        public EntityIdValidationAttribute(Type entityType)
        {
            _entityType = entityType;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Initialize(validationContext);
            
            var httpContextAccessor = validationContext.GetService<IHttpContextAccessor>();
            var user = httpContextAccessor.HttpContext.User;
            
            
            var entity = DbContext.Find(_entityType, value);
            

            if (entity != null  
                && entity is Entity domainEntity 
                && domainEntity.UserId == user.Identity.Name)
            {
                validationContext.Items[nameof(EntityIdValidationAttribute)] = entity;
                return ValidationResult.Success;
            }

            return new ValidationResult($"Entity {_entityType.Name} with id = {value} was not found");
        }
    }
}