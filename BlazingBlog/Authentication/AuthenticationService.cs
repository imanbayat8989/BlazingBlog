using BlazingBlog.Models;
using BlazingBlog.Services;

namespace BlazingBlog.Authentication
{
	public class AuthenticationService
	{
		private readonly UserService _userService;

        public AuthenticationService(UserService userService)
        {
            _userService = userService;
        }

        public async Task<LoggedInUser?> GetUserAsync(LoginModel loginModel)
        {
            var loggedInUser =await _userService.LogingAsync(loginModel);
            return loggedInUser;
        }
    }
}
