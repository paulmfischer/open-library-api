using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using OpenLibraryApi.Models;

namespace OpenLibraryApi.API;

public class SearchService : ISearchService
{
    private readonly HttpClient httpClient;

    public SearchService(HttpClient _httpClient) => httpClient = _httpClient;
    
    public async Task<SearchResponse> GeneralSearch(string searchTerm)
    {
        Console.WriteLine($"making call to {this.httpClient.BaseAddress} with search term {searchTerm}");
        SearchResponse? response = await
            httpClient.GetFromJsonAsync<SearchResponse>(
                $"search.json?q={searchTerm.Replace(' ', '+')}",
                new JsonSerializerOptions(JsonSerializerDefaults.General)
            )
            ?? throw new WebException("Did not receive a proper message from open-library");
        return response;
    }
}