using Tasprof.Apps.MyWorkouts.Models;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Tasprof.Apps.MyWorkouts.Interfaces
{
   public interface IWorkoutsService
    {
        Task<ObservableCollection<Workout>> GetWorkoutsAsync();
        Task<Workout> SaveWorkoutAsync(int id, DateTime date, string location);
    }
}
