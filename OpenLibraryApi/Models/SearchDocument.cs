namespace OpenLibraryApi.Models;

public class SearchDocument
{
  public int cover_i { get; set; }
  public bool has_fulltext { get; set; }
  public int edition_count { get; set; }
  public string title { get; set; }
  public ICollection<string> author_name { get; set; }
  public int first_publish_year { get; set; }
  public string key { get; set; }
  public ICollection<string> ia { get; set; }
  public ICollection<string> author_key { get; set; }
  public bool public_scan_b { get; set; }
}