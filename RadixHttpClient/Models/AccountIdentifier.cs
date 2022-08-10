using Newtonsoft.Json;

namespace RadixHttpClient.Models
{
    public class AccountIdentifier
    {
        [JsonProperty("address")]
        public string Address { get; set; }
    }
}
