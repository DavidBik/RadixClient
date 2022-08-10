using RadixHttpClient.Models.Responses;
using System.Threading.Tasks;

namespace RadixHttpClient.Interfaces
{
    public interface ITokenService
    {
        Task<GatewayResponse> GetTokenInformation();
    }
}
