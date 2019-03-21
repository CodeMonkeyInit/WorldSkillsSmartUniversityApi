using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using WorldSkillsSmartUniversityApi.Helpers;

namespace WorldSkillsSmartUniversityApi.Models.Domain
{
    public class Device : Entity
    {
        [JsonIgnore]
        public int RoomId { get; set; }

        public Room Room { get; set; }

        [JsonIgnore]
        public DeviceType Type { get; set; }

        public string TypeName => Type.GetAttributeOfType<DisplayNameAttribute>()
            .DisplayName;

        public string Name { get; set; }

        public string Value { get; set; }

        [JsonIgnore]
        public List<MacroDevice> Macros { get; set; }

        [JsonIgnore]
        public string[] ValidValues => GetValidValues();

        private string[] GetValidValues()
        {
            string[] GetRange(int start, int count) =>
                Enumerable.Range(start, count)
                    .Select(level => level.ToString())
                    .ToArray();

            switch (Type)
            {
                case DeviceType.LightBulb:
                case DeviceType.Switch:
                    return new[] {"on", "of"};
                case DeviceType.Humidifier:
                    return GetRange(0, 100);
                case DeviceType.Door:
                case DeviceType.Window:
                    return new[] {"opened", "closed"};
                case DeviceType.AirConditioner:
                    return GetRange(10, 40 - 10);
                case DeviceType.TemperatureSensor:
                    return GetRange(-30, 100);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}