using Newtonsoft.Json;

namespace RadixHttpClient.Models.Responses
{
    public class AccountResponse
    {
        [JsonProperty("ledger_state")]
        public LedgerState LedgerState { get; set; }

        [JsonProperty("account_balances")]
        public AccountBalances AccountBalances { get; set; }
    }
}
