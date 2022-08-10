using Newtonsoft.Json;

namespace RadixHttpClient.Models
{
    public class TokenProperties
    {
        [JsonProperty("icon_url")]
        public string IconUrl { get; set; }

        [JsonProperty("is_supply_mutable")]
        public bool IsSupplyMutable { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("granularity")]
        public string Granularity { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
