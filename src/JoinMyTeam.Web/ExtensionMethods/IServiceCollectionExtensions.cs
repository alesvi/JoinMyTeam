using JoinMyTeam.Business.Fixture;
using Microsoft.Extensions.DependencyInjection;

namespace WillAttend.Web.ExtensionMethods
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddTransient<IFixtureBusiness, FixtureBusiness>();

            return services;
        }
    }
}
