using Common.Data.Rest;
using Common.Data.Rest.Caller;
using Common.Data.Rest.Caller.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Web.Components
{
    public static class DependencyRegister
    {
        public static void Register(IServiceCollection services)
        {
            services.AddSingleton(typeof(AuctionHubRestClient), AuctionHubRestClient.Create());
            services.AddSingleton<IAccountRestCaller, AccountRestCaller>();

            
        }
    }
}
