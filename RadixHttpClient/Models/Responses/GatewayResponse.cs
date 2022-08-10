using Newtonsoft.Json;

namespace RadixHttpClient.Models.Responses
{
    public class GatewayResponse
    {
        [JsonProperty("network_identifier")]
        public NetworkIdentifier NetworkIdentifier { get; set; }

        [JsonProperty("gateway_api")]
        public GatewayInfo GatewayInfo { get; set; }

        [JsonProperty("ledger_state")]
        public LedgerState LedgerState { get; set; }

        [JsonProperty("target_ledger_state")]
        public TargetLedgerState TargetLedgerState { get; set; }
    }
}
