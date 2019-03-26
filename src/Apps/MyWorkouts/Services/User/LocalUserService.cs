using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tasprof.Apps.MyWorkouts.Models;
using Tasprof.Apps.MyWorkouts.Models.User;

namespace Tasprof.Apps.MyWorkouts.Services.User
{
    public class LocalUserService : IUserService
    {
        private readonly MyWorkoutsDatabase _database;

        public LocalUserService()
        {
            _database = GlobalSettings.Database;
        }

        public async Task<bool> ExistsUserAsync(string username)
        {
            var userInfo = await _database.Database.Table<UserInfo>().Where(u => u.Username == username).FirstOrDefaultAsync();
            return userInfo != null;
        }

        public async Task<UserInfo> AddUserAsync(string username, string password)
        {
            var userInfo = new UserInfo() { Username = username, Password = password, UserId = Guid.NewGuid() };
            await _database.Database.InsertAsync(userInfo);
            return userInfo;
        }

        public async Task<string> GetAuthorizeTokenAsync(string username, string password)
        {
            var userInfo = await _database.Database.Table<UserInfo>().Where(u => u.Username == username && u.Password == password).FirstOrDefaultAsync();
            if (userInfo != null)
            {
                return "1";
            }
            return string.Empty;
        }


        #region Private Methods 


        #endregion
    }
}
