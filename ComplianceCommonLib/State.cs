using System.Text.Json.Serialization;

namespace ComplianceCommonLib
{
    // Add other states as needed...
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum State
    {
        CA,
        MD,
        NY, 
        VA,
        FL
    }
}
