using RadixHttpClient.Interfaces;
using RadixHttpClient.Models.Responses;
using System.Threading.Tasks;

namespace RadixHttpClient.Services
{
    public class GatewayService : IGatewayService
    {
        public Task<GatewayResponse> GetGatewayInfo()
        {
            return Task.FromResult(new GatewayResponse());
        }
    }
}
