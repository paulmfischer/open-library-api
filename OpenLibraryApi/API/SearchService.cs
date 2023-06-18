using Microsoft.Extensions.Configuration;
using OpenLibraryApi.Configuration;

public class SearchService : ISearchService
{
    private readonly ApiConfiguration configuration;

    public SearchService(ApiConfiguration configuration)
    {
        this.configuration = configuration;
    }
    
    public Task Search(string searchTerm)
    {
        Console.WriteLine($"search api config setting {this.configuration.SearchApi}");
        Console.WriteLine($"Searching Open API for {searchTerm}");
        return Task.CompletedTask;
    }
}