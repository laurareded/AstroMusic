namespace AstromusicApi.Dtos;
public class UserSignResponse
{
    public string FullName { get; set; }
    public string Email { get; set; }
    public DateTime BirthDate { get; set; }
    public string SignName { get; set; }
    public string Description { get; set; }
    public string ThemeSong { get; set; }
    public string SongArtist { get; set; }
    public string SongLink { get; set; }
    public string ImageUrl { get; set; }
}