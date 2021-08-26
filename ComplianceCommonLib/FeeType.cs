using System.Text.Json.Serialization;
namespace ComplianceCommonLib
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FeeType
    {
        FloodCertification, 
        Processing, 
        Settlement,
        Application,
        CreditReport,
        TitleSearch,
        Other // to capture all others
    }
}
