using System;
using SQLite;

namespace Tasprof.Apps.MyWorkouts.Models.User
{
    public class UserInfo
    {
        [PrimaryKey]
        public Guid UserId { get; set; }

        [MaxLength(80), Unique]
        public string Username { get; set; }
        
        public string Password { get; set; }
    }
}
