namespace WorldSkillsSmartUniversityApi.Models.Domain
{
    public class MacroDevice
    {
        public int MacroId { get; set; }

        public Macro Macro { get; set; }

        public int DeviceId { get; set; }

        public Device Device { get; set; }

        public string Value { get; set; }
    }
}