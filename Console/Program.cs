using System.Text.Json;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OpenLibraryApi.API;
using OpenLibraryApi.Configuration;

IConfiguration config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();
var apiConfiguration = new ApiConfiguration(config.GetValue<string>("ApiUrl"));

using IHost host = Host
    .CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) =>
    {
        services.AddSingleton(apiConfiguration);
        services.UseOpenLibraryApi(apiConfiguration);
    })
    .Build();

Console.Write("Enter a search term: ");
var searchTerm = Console.ReadLine();
ArgumentException.ThrowIfNullOrEmpty(searchTerm, nameof(searchTerm));

ISearchService searchService = host.Services.GetService<ISearchService>() ?? throw new NullReferenceException("ISearch Service not registered correctly.");
var results = await searchService.GeneralSearch(searchTerm);
Console.WriteLine($"Found a total of {results.NumberFound} results for the search term {searchTerm}");
File.WriteAllText(@".\output\response.json", JsonSerializer.Serialize(results, new JsonSerializerOptions { WriteIndented = true }));