using System;
using System.ComponentModel.DataAnnotations;

namespace WorldSkillsSmartUniversityApi.Validators
{
    [AttributeUsage(AttributeTargets.Property)]
    public class EntityIdValidationAttribute : ValidationBaseAttribute
    {
        private Type _entityType;

        public EntityIdValidationAttribute(Type entityType)
        {
            _entityType = entityType;
        }
        
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Initialize(validationContext);

            var entity = DbContext.Find(_entityType, value);

            if (entity != null)
            {
                return ValidationResult.Success;
            }
            
            return new ValidationResult($"Entity {_entityType.Name} with id = {value} was not found");
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class DeviceValueValidationAttribute : ValidationBaseAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Initialize(validationContext);
            
            throw new NotImplementedException();
        }
    }
}