using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WorldSkillsSmartUniversityApi.Models.Domain
{
    public enum DeviceType
    {
        [DisplayName("Переключатель")]
        Switch,
        [DisplayName("Лампа")]
        LightBulb,
        [DisplayName("Дверь")]
        Door,
        [DisplayName("Кондиционер")]
        AirConditioner,
        [DisplayName("Окно")]
        Window,
        [DisplayName("Увлажнитель воздуха")]
        Humidifier,
        [DisplayName("Датчик температуры")]
        TemperatureSensor
    }
}