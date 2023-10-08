using BlazingBlog.Data;
using BlazingBlog.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazingBlog.Services
{
	public class UserService
	{
        private readonly BlogContext _blogContext;
        public UserService(BlogContext blogContext)
        {
            _blogContext = blogContext;
        }

        public async Task<LoggedInUser?> LogingAsync(LoginModel model)
        {
            var dbUser = await _blogContext.Users.AsNoTracking().FirstOrDefaultAsync
                (u => u.Email == model.UserName);

            if (dbUser == null)
            {
                return new LoggedInUser(dbUser.Id, $"{dbUser.FirstName} {dbUser.LastName}".Trim());
            }
            else
            {
                return null;
            }
        }
    }
}
