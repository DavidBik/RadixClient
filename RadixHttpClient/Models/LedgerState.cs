using Newtonsoft.Json;

namespace RadixHttpClient.Models
{
    public class LedgerState
    {
        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("epoch")]
        public int Epoch { get; set; }

        [JsonProperty("round")]
        public int Round { get; set; }
    }
}
