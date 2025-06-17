namespace AstromusicApi.models;
public class ZodiacSign
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int StartMonth { get; set; }
    public int StartDay { get; set; }
    public int EndMonth { get; set; }
    public int EndDay { get; set; }
    public string Description { get; set; }
    public string ThemeSong { get; set; }
    public string SongArtist { get; set; }
    public string SongLink { get; set; }
    public string ImageUrl { get; set; }
    public ICollection<User> Users { get; set; }
}
