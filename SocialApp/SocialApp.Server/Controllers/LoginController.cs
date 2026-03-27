using Microsoft.AspNetCore.Mvc;
using SocialApp.Server.Models;
using SocialApp.Server.Services;

namespace SocialApp.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController(ILoginService loginService) : ControllerBase
    {
        [HttpGet]
        public IActionResult Login(string provider)
        {
            if (string.IsNullOrEmpty(provider))
                return BadRequest("Provider is required");

            // Check provider validity (ignore case)
            if (!Enum.TryParse<SocialProvider>(provider, true, out var parsedProvider))
                return BadRequest(new { error = "Invalid provider", allowed = Enum.GetNames<SocialProvider>() });

            var user = loginService.GetUser(parsedProvider);
            return Ok(user);
        }
    }
}
