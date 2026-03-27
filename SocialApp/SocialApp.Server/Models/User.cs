namespace SocialApp.Server.Models;

public class User
{
    public string Name { get; set; } = string.Empty;
    public required string Email { get; set; }
    public string Phone { get; set; } = string.Empty;
    public string ProfilePicture { get; set; } = string.Empty;
    public List<UserPost> Posts { get; set; } = [];
}
