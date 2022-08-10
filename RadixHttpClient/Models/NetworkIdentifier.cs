using Newtonsoft.Json;

namespace RadixHttpClient.Models
{
    public class NetworkIdentifier
    {
        [JsonProperty("network")]
        public string Network { get; set; }
    }
}
