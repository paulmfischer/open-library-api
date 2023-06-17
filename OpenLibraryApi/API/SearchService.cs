using Microsoft.Extensions.Configuration;

public class SearchService : ISearchService
{
    private readonly IConfiguration configuration;

    public SearchService(IConfiguration configuration)
    {
        this.configuration = configuration;
    }
    
    public Task Search(string searchTerm)
    {
        Console.WriteLine($"search api config setting {this.configuration.GetValue<string>("SearchAPI")}");
        Console.WriteLine($"Searching Open API for {searchTerm}");
        return Task.CompletedTask;
    }
}