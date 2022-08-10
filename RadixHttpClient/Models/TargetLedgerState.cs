using Newtonsoft.Json;

namespace RadixHttpClient.Models
{
    public class TargetLedgerState
    {
        [JsonProperty("version")]
        public int Version { get; set; }
    }
}
