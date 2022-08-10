using Newtonsoft.Json;

namespace RadixHttpClient.Models
{
    public class TokenIdentifier
    {
        [JsonProperty("rri")]
        public string RadixResourceIdentifier { get; set; }
    }
}
