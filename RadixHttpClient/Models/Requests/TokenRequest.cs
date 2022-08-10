using Newtonsoft.Json;

namespace RadixHttpClient.Models.Requests
{
    public class TokenRequest
    {
        [JsonProperty("network_identifier")]
        public NetworkIdentifier NetworkIdentifier { get; set; }

        [JsonProperty("token_identifier")]
        public TokenIdentifier TokenIdentifier { get; set; }
    }
}
