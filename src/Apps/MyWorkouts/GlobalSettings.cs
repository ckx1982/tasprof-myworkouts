using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Tasprof.Apps.MyWorkouts.Models;

namespace Tasprof.Apps.MyWorkouts
{
    public class GlobalSettings
    {
        public static GlobalSettings Instance { get; } = new GlobalSettings();

        static MyWorkoutsDatabase _database;
        public static MyWorkoutsDatabase Database
        {
            get
            {
                if (_database == null)
                {
                    _database = new MyWorkoutsDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MyWorkouts.db3"));
                }
                return _database;
            }
        }
    }
}
