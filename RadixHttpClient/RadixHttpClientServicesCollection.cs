using Microsoft.Extensions.DependencyInjection;
using RadixHttpClient.Interfaces;
using RadixHttpClient.Services;

namespace RadixHttpClient
{
    public static class RadixHttpClientServicesExtension
    {
        public static IServiceCollection AddRadixHttpClientServices(this IServiceCollection services)
        {
            services.AddTransient<IGatewayService, GatewayService>()
                    .AddTransient<IAccountService, AccountService>();
            return services;
        }
    }
}
