using System.Text.Json.Serialization;

namespace ComplianceCommonLib
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ResidenceType
    {
        Primary, 
        Secondary
    }
}