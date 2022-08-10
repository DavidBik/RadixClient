using Newtonsoft.Json;
using System.Collections.Generic;

namespace RadixHttpClient.Models
{
    public class AccountBalances
    {
        [JsonProperty("staked_and_unstaking_balance")]
        public TokenValue StakedUnstakingBalance { get; set; }

        [JsonProperty("liquid_balances")]
        public List<TokenValue> LiquidBalances { get; set; }

    }
}
