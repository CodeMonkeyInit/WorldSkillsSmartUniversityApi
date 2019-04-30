using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using WorldSkillsSmartUniversityApi.Models;
using WorldSkillsSmartUniversityApi.Models.Domain;

namespace WorldSkillsSmartUniversityApi.Validators
{
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