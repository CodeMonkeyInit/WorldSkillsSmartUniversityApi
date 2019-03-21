using Newtonsoft.Json;

namespace WorldSkillsSmartUniversityApi.Models.Domain
{
    public class MacroDevice
    {
        [JsonIgnore]
        public int MacroId { get; set; }

        [JsonIgnore]
        public Macro Macro { get; set; }

        public int DeviceId { get; set; }

        [JsonIgnore]
        public Device Device { get; set; }

        public string Value { get; set; }
    }
}