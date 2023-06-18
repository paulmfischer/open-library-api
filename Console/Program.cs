using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OpenLibraryApi.Configuration;

IConfiguration config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();
var apiConfiguration = new ApiConfiguration(config.GetValue<string>("SearchApi"));
Console.WriteLine($"checking api config: {apiConfiguration.SearchApi}");

using IHost host = Host
    .CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) =>
    {
        services.AddSingleton(apiConfiguration);
        services.UseOpenLibraryApi();
    })
    .Build();

Console.Write("Enter a search term: ");
var searchTerm = Console.ReadLine();
ArgumentException.ThrowIfNullOrEmpty(searchTerm, nameof(searchTerm));

ISearchService searchService = host.Services.GetService<ISearchService>() ?? throw new NullReferenceException("ISearch Service not registered correctly.");
await searchService.Search(searchTerm);