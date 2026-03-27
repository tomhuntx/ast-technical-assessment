using SocialApp.Server.Models;

namespace SocialApp.Server.Services;

public interface ILoginService
{
    /// <summary>
    /// Get the user profile for the given provider.
    /// Note that no authorisation has been added for the purpose of this assessment.
    /// </summary>
    /// <param name="provider">Accepted social provider platform</param>
    /// <returns>User details and post history</returns>
    User GetUser(SocialProvider provider);
}
