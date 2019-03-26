using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tasprof.Apps.MyWorkouts.Models.User;

namespace Tasprof.Apps.MyWorkouts.Services.User
{
    public interface IUserService
    {
        Task<bool> ExistsUserAsync(string username);
        Task<UserInfo> AddUserAsync(string username, string password);
        Task<string> GetAuthorizeTokenAsync(string username, string password);
    }
}
