using RadixHttpClient.Interfaces;
using RadixHttpClient.Models;
using RadixHttpClient.Models.Responses;
using System.Threading.Tasks;

namespace RadixHttpClient.Services
{
    public class AccountService : IAccountService
    {
        public Task<AccountResponse> GetBalances(AccountIdentifier accountIdentifier)
        {
            return Task.FromResult(new AccountResponse());
        }

        public Task<AccountResponse> GetStakePositions(AccountIdentifier accountIdentifier)
        {
            return Task.FromResult(new AccountResponse());
        }

        public Task<AccountResponse> GetTransactions(AccountIdentifier accountIdentifier, int limit)
        {
            return Task.FromResult(new AccountResponse());
        }

        public Task<AccountResponse> GetUnstakePositions(AccountIdentifier accountIdentifier)
        {
            return Task.FromResult(new AccountResponse());
        }
    }
}
