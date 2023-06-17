using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OpenLibraryApi.Configuration;

IConfiguration config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

using IHost host = Host
    .CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) =>
    {
        // services.AddTransient<ISearchService, SearchService>();
        services.UseOpenLibraryApi();
        // var myConfigurationSection = configuration.GetSection("app");

        // services.AddSingleton<IValidateOptions<AppOptions>, AppOptionsValidator>();
        // services.Configure<AppOptions>(myConfigurationSection);
    })
    .Build();

    
// var apiConfiguration = new ApiConfiguration(config.GetValue<string>("SearchApi"));

Console.Write("Enter a search term: ");
var searchTerm = Console.ReadLine();
ArgumentException.ThrowIfNullOrEmpty(searchTerm, nameof(searchTerm));

ISearchService searchService = host.Services.GetService<ISearchService>() ?? throw new NullReferenceException("ISearch Service not registered correctly.");
await searchService.Search(searchTerm);

// host.Run(); 