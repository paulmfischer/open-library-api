using OpenLibraryApi.Models;

namespace OpenLibraryApi.API;

public interface ISearchService
{
    Task<SearchResponse> GeneralSearch(string searchTerm);
}