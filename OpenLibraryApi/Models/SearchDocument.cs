using System.Text.Json.Serialization;

namespace OpenLibraryApi.Models;

public class SearchDocument
{
  [JsonPropertyName("cover_i")]
  public int? CoverIndex { get; set; }
  [JsonPropertyName("has_fulltext")]
  public bool HasFulltext { get; set; }
  [JsonPropertyName("edition_count")]
  public int EditionCount { get; set; }
  [JsonPropertyName("title")]
  public string Title { get; set; } = string.Empty;
  [JsonPropertyName("author_name")]
  public ICollection<string> AuthorName { get; set; } = new List<string>();
  [JsonPropertyName("first_publish_year")]
  public int FirstPublishYear { get; set; }
  [JsonPropertyName("key")]
  public string Key { get; set; } = string.Empty;
  [JsonPropertyName("ia")]
  public ICollection<string> IA { get; set; } = new List<string>();
  [JsonPropertyName("author_key")]
  public ICollection<string> AuthorKey { get; set; } = new List<string>();
  [JsonPropertyName("public_scan_b")]
  public bool PublicScanB { get; set; }
  [JsonPropertyName("isbn")]
  public ICollection<string> ISBN { get; set; } = new List<string>();
}