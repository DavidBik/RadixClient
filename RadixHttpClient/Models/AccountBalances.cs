using Newtonsoft.Json;
using System.Collections.Generic;

namespace RadixHttpClient.Models
{
    public class AccountBalances
    {
        [JsonProperty("staked_and_unstaking_balance")]
        public StakedAndUnstakingBalance StakedUnstakingBalance { get; set; }

        [JsonProperty("liquid_balances")]
        public List<LiquidBalance> LiquidBalances { get; set; }

    }
}
