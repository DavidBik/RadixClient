using Newtonsoft.Json;

namespace RadixHttpClient.Models
{
    public class TokenValue
    {
        [JsonProperty("token_identifier")]
        public TokenIdentifier TokenIdentifier { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
