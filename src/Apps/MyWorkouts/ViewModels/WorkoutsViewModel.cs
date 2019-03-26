using Tasprof.Apps.MyWorkouts.Interfaces;
using Tasprof.Apps.MyWorkouts.Models;
using Tasprof.Apps.MyWorkouts.ViewModels.Base;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Tasprof.Apps.MyWorkouts.ViewModels
{
    public class WorkoutsViewModel : ViewModelBase
    {
        public string WorkoutLabel = "Workout:";
        private ObservableCollection<Workout> _workouts;
        private IWorkoutsService _workoutsService;


        #region Public Properties
        public ICommand AddWorkoutCommand => new Command(async () => await AddWorkoutAsync());

        public ObservableCollection<Workout> Workouts
        {
            get { return _workouts; }
            set
            {
                _workouts = value;
                RaisePropertyChanged(() => Workouts);
            }
        }

        #endregion

        #region Constructors

        public WorkoutsViewModel()
        {

        }

        public WorkoutsViewModel(IWorkoutsService workoutsService)
        {
            _workoutsService = workoutsService;
        }

        #endregion

        #region Public Methods
        public override async Task InitializeAsync(object navigationData)
        {
            Workouts = await _workoutsService.GetWorkoutsAsync();
        }
        #endregion

        #region Private Methods

        private async Task AddWorkoutAsync()
        {
            await NavigationService.NavigateToAsync<AddWorkoutViewModel>();
        }

        #endregion
    }
}
