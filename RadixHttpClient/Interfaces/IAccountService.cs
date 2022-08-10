using RadixHttpClient.Models;
using RadixHttpClient.Models.Responses;
using System.Threading.Tasks;

namespace RadixHttpClient.Interfaces
{
    public interface IAccountService
    {
        Task<AccountResponse> GetBalances(AccountIdentifier accountIdentifier);
        Task<AccountResponse> GetStakePositions(AccountIdentifier accountIdentifier);
        Task<AccountResponse> GetUnstakePositions(AccountIdentifier accountIdentifier);
        Task<AccountResponse> GetTransactions(AccountIdentifier accountIdentifier, int limit);
    }
}
