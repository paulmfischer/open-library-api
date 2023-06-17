using Microsoft.Extensions.DependencyInjection;

public static class StartupExtensions
{
    public static void UseOpenLibraryApi(this IServiceCollection services)
    {
        services.AddScoped<ISearchService, SearchService>();
    }
}