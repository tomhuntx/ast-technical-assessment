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
            Phone = "0411222333",
            ProfilePicture = GetDummyProfileImage(provider),
            Posts = GetDummyPosts(provider)
        };
    }

    private static string GetDummyProfileImage(SocialProvider provider)
    {
        return provider switch
        {
            SocialProvider.Facebook => "https://picsum.photos/id/237/200",
            SocialProvider.Twitter => "https://picsum.photos/seed/twitter-profile/200",
            SocialProvider.LinkedIn => "https://picsum.photos/seed/linkedin-profile/200",
            _ => "https://picsum.photos/seed/default-profile/200"
        };
    }

    private static List<UserPost> GetDummyPosts(SocialProvider provider)
    {
        return provider switch
        {
            SocialProvider.Facebook =>
                [
                    new UserPost { Text = "Nothing beats a bright sunny day outdoors ☀️", Image = "https://picsum.photos/seed/fb1/600/400" },
                new UserPost { Text = "Good food, fresh air, and great company 🔥", Image = "https://picsum.photos/seed/fb2/600/400" },
                new UserPost { Text = "Still thinking about this beautiful getaway ❤️", Image = "https://picsum.photos/seed/fb3/600/400" }
                ],

            SocialProvider.Twitter =>
                [
                    new UserPost { Text = "Late night coding session vibes 💻", Image = "https://picsum.photos/seed/tw1/600/400" },
                new UserPost { Text = "Powered by caffeine as always ☕", Image = "https://picsum.photos/seed/tw2/600/400" },
                new UserPost { Text = "When things finally start working 😅", Image = "https://picsum.photos/seed/tw3/600/400" }
                ],

            SocialProvider.LinkedIn =>
                [
                    new UserPost { Text = "Excited to bring this project to life 🚀", Image = "https://picsum.photos/seed/li1/600/400" },
                new UserPost { Text = "Great conversations and meaningful connections 🤝", Image = "https://picsum.photos/seed/li2/600/400" },
                new UserPost { Text = "Always learning, always improving 📈", Image = "https://picsum.photos/seed/li3/600/400" }
                ],
            _ => []
        };
    }
}
