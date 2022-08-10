using Newtonsoft.Json;

namespace RadixHttpClient.Models
{
    public class StakedAndUnstakingBalance
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("token_identifier")]
        public TokenIdentifier TokenIdentifier { get; set; }

    }
}
