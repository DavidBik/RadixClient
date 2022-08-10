using RadixHttpClient.Interfaces;
using RadixHttpClient.Models.Responses;
using System.Threading.Tasks;

namespace RadixHttpClient.Services
{
    public class TokenService : ITokenService
    {
        public Task<GatewayResponse> GetTokenInformation()
        {
            return Task.FromResult(new GatewayResponse());
        }
    }
}
