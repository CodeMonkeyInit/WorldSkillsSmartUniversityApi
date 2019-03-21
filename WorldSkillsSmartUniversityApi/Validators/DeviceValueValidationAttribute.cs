using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using WorldSkillsSmartUniversityApi.Models;
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

            var entity = DbContext.Find(_entityType, value);

            if (entity != null)
            {
                validationContext.Items[nameof(EntityIdValidationAttribute)] = entity;
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

            var deviceId = (validationContext.ObjectInstance as DeviceViewModel)?.Id ?? throw new InvalidOperationException();

            var device = DbContext.Devices.Find(deviceId);
            
            if(device == null)
                return new ValidationResult($"Unknown device type");
            
            if (value is string deviceValue)
            {
                string[] validValues = device.ValidValues;

                if (validValues.Contains(deviceValue))
                {
                    return ValidationResult.Success;
                }

                return new ValidationResult(
                    $"Device value = {deviceValue} is not valid for this type of device. " +
                    $"Valid values [{validValues.First()}..{validValues.Last()}]");
            }

            throw new ArgumentException("Attribute use on non string value");
        }
    }
}