using System.Text.Json.Serialization;

namespace DotNet_RPG.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))] //Attribute allowing us to see the string representations of our enums.
    public enum RpgClass
    {
        Swordsman,
        Mage,
        Healer
    }
}