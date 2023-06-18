namespace OpenLibraryApi.Models;

public class SearchResponse
{
  public int start { get; set; }
  public int num_found { get; set; }
  public ICollection<SearchDocument> docs { get; set; }
}