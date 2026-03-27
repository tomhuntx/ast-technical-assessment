using SocialApp.Server.Models;

namespace SocialApp.Server.Services;

public class LoginService : ILoginService
{
    public User GetUser(SocialProvider provider)
    {
        return new User
        {
            Name = "Geraldine Smith",
            Email = "gsmith@gmail.com",
            Phone = "+614000000",
            ProfilePicture = GetDummyProfileImage(provider),
            Posts = GetDummyPosts(provider)
        };
    }

    private static string GetDummyProfileImage(SocialProvider provider)
    {
        return provider switch
        {
            SocialProvider.Facebook => "https://picsum.photos/id/237/200",
            SocialProvider.Twitter => "https://picsum.photos/200",
            SocialProvider.LinkedIn => "https://picsum.photos/200",
            _ => "https://picsum.photos/200"
        };
    }

    private static List<UserPost> GetDummyPosts(SocialProvider provider)
    {
        return provider switch
        {
            SocialProvider.Facebook =>
                [
                    new UserPost { Text = "Enjoying a sunny day ☀️", Image = "https://picsum.photos/600/400" },
                    new UserPost { Text = "Family BBQ this weekend!", Image = "https://picsum.photos/600/400" },
                    new UserPost { Text = "Holiday memories ❤️", Image = "https://picsum.photos/600/400" }
                ],

            SocialProvider.Twitter =>
                [
                    new UserPost { Text = "Just shipped some code 🚀", Image = "https://picsum.photos/600/400" },
                    new UserPost { Text = "Coffee is life ☕", Image = "https://picsum.photos/600/400" },
                    new UserPost { Text = "Debugging... again 😅", Image = "https://picsum.photos/600/400" }
                ],

            SocialProvider.LinkedIn =>
                [
                    new UserPost { Text = "Excited to share my latest project!", Image = "https://picsum.photos/600/400" },
                    new UserPost { Text = "Networking with amazing professionals.", Image = "https://picsum.photos/600/400" },
                    new UserPost { Text = "Continuous learning is key to growth.", Image = "https://picsum.photos/600/400" }
                ],
            _ => []
        };
    }
}
