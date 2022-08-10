using Newtonsoft.Json;

namespace RadixHttpClient.Models.Responses
{
    public class TokenResponse
    {
        [JsonProperty("token_identifier")]
        public TokenIdentifier TokenIdentifier { get; set; }

        [JsonProperty("token_supply")]
        public TokenValue TokenSupply { get; set; }

        [JsonProperty("info")]
        public TokenInformation Information { get; set; }

        [JsonProperty("token_properties")]
        public TokenProperties TokenProperties { get; set; }
    }
}
}
