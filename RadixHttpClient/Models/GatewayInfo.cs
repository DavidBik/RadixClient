using Newtonsoft.Json;

namespace RadixHttpClient.Models
{
    public class GatewayInfo
    {
        [JsonProperty("version")]
        public string Version { get; set; }
        [JsonProperty("open_api_schema_version")]
        public string OpenApiSchemaVersion { get; set; }
    }
}
