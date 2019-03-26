using Tasprof.Apps.MyWorkouts.Models;
using Tasprof.Apps.MyWorkouts.Models.User;


namespace Tasprof.Apps.MyWorkouts.Validations
{
    public class UserExistsRule<T>: IValidationRule<T>
    {
        private readonly MyWorkoutsDatabase _database;
        public string ValidationMessage { get; set; }
        public string ValidationType { get; set; }

        public UserExistsRule()
        {
            _database = GlobalSettings.Database;
        }

        public bool Check(T value)
        {
            if (value ==null)
            {
                return true;
            }

            var username = value as string;
            var dbUserInfo = _database.Database.Table<UserInfo>().Where( u => u.Username == username).FirstOrDefaultAsync();
            return dbUserInfo.Result == null;
        }
    }
}
