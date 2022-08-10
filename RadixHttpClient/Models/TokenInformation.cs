using Newtonsoft.Json;

namespace RadixHttpClient.Models
{
    public class TokenInformation
    {
        [JsonProperty("total_burned")]
        public TokenValue TotalBurned { get; set; }

        [JsonProperty("total_minted")]
        public TokenValue TotalMinted { get; set; }

    }
}
