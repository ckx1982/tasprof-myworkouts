using Tasprof.Apps.MyWorkouts.Interfaces;
using Tasprof.Apps.MyWorkouts.Models;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Tasprof.Apps.MyWorkouts.Services
{
    public class WorkoutsService : IWorkoutsService
    {
        private readonly ObservableCollection<Workout> _workouts;

        public WorkoutsService()
        {
            _workouts = new ObservableCollection<Workout>();
            _workouts.Add(new Workout(1, new DateTime(2018, 10, 26), "Gym"));
            _workouts.Add(new Workout(2, new DateTime(2018, 10, 22), "Gym"));
            _workouts.Add(new Workout(3, new DateTime(2018, 10, 18), "Gym"));
        }

        public async Task<ObservableCollection<Workout>> GetWorkoutsAsync()
        {
            await Task.Delay(1);
            return _workouts;
        }

        public async Task<Workout> SaveWorkoutAsync(int id, DateTime date, string location)
        {
            await Task.Run(() =>
             {
                 _workouts.Add(new Workout(_workouts.Count + 1, DateTime.Today, "Gym"));
             });
            return _workouts[_workouts.Count - 1];
        }
    }
}
