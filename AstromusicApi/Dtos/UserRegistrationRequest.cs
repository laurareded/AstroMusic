namespace AstromusicApi.Dtos;
public class UserRegistrationRequest
{
    public string FullName { get; set; }
    public string Email { get; set; }
    public DateTime BirthDate { get; set; }
}