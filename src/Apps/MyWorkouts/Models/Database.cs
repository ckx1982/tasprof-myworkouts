using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Tasprof.Apps.MyWorkouts.Models.User;

namespace Tasprof.Apps.MyWorkouts.Models
{
   public class MyWorkoutsDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public MyWorkoutsDatabase(string dbPath)
        {

            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<UserInfo>();
        }


        public SQLiteAsyncConnection Database
        {
            get
            {
                return _database;
            }
        }
    
    }
}
