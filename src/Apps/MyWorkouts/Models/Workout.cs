using System;

namespace Tasprof.Apps.MyWorkouts.Models
{
    public class Workout
    {
        public int WorkoutId { get; set; }
        public DateTime WorkoutDate { get; set; }
        public string WorkoutLocation { get; set; }

        public Workout(int id, DateTime date, string location)
        {
            WorkoutId = WorkoutId;
            WorkoutDate = date;
            WorkoutLocation = location;
        }
    }
}
