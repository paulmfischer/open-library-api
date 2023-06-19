using System.Text.Json.Serialization;

namespace OpenLibraryApi.Models;

public class SearchResponse
{
  [JsonPropertyName("start")]
  public int Start { get; set; }
  [JsonPropertyName("num_found")]
  public int NumberFound { get; set; }
  [JsonPropertyName("docs")]
  public ICollection<SearchDocument> Docs { get; set; } = new List<SearchDocument>();
}