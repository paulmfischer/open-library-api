namespace OpenLibraryApi.Configuration;

public class ApiConfiguration
{
    public string SearchApi { get; set; }

    public ApiConfiguration(string? searchApi)
    {
        ArgumentException.ThrowIfNullOrEmpty(searchApi, nameof(searchApi));
        
        this.SearchApi = searchApi;
    }
}