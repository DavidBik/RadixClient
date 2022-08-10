using Newtonsoft.Json;

namespace RadixHttpClient.Models.Requests
{
    public class AccountRequest
    {
        [JsonProperty("network_identifier")]
        public NetworkIdentifier NetworkIdentifier { get; set; }

        [JsonProperty("account_identifier")]
        public AccountIdentifier AccountIdentifier { get; set; }

        [JsonProperty("cursor")]
        public string Cursor { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }
    }
}
