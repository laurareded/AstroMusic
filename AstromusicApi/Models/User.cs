namespace AstromusicApi.models;
public class User
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public DateTime BirthDate { get; set; }
    public int ZodiacSignId { get; set; }
    public ZodiacSign ZodiacSign { get; set; }
}
