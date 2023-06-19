using Microsoft.Extensions.DependencyInjection;
using OpenLibraryApi.API;

namespace OpenLibraryApi.Configuration;

public static class StartupExtensions
{
    public static void UseOpenLibraryApi(this IServiceCollection services, ApiConfiguration configuration)
    {
        services.AddHttpClient<ISearchService, SearchService>(
            client => {
                client.BaseAddress = new Uri(configuration.ApiUrl);
            }
        );
    }
}