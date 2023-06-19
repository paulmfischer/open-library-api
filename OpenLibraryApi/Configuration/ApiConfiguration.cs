namespace OpenLibraryApi.Configuration;

public class ApiConfiguration
{
    public string ApiUrl { get; set; }

    public ApiConfiguration(string? apiUrl)
    {
        ArgumentException.ThrowIfNullOrEmpty(apiUrl, nameof(apiUrl));
        
        this.ApiUrl = apiUrl;
    }
}