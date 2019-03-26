using Tasprof.Apps.MyWorkouts.Interfaces;
using Tasprof.Apps.MyWorkouts.Validations;
using Tasprof.Apps.MyWorkouts.ViewModels.Base;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Tasprof.Apps.MyWorkouts.ViewModels
{
    public class AddWorkoutViewModel : ViewModelBase
    {

        #region Properties

        public ICommand SaveWorkoutCommand => new Command(async () => await SaveWorkoutAsync());
        public ICommand CancelCommand => new Command(async () => await NavigateToWorkoutsAsync());

        private IWorkoutsService _workoutsService;

        private ValidatableObject<int> _workoutId;
        public ValidatableObject<int> WorkoutId
        {
            get
            {
                return _workoutId;
            }

            set
            {
                _workoutId = value;
                RaisePropertyChanged(() => WorkoutId);
            }
        }

        private ValidatableObject<DateTime> _workoutDate;
        public ValidatableObject<DateTime> WorkoutDate
        {
            get
            {
                return _workoutDate;
            }
            set
            {
                _workoutDate = value;
                RaisePropertyChanged(() => WorkoutDate);
            }
        }

        private ValidatableObject<string> _workoutLocation;
        public ValidatableObject<string> WorkoutLocation
        {
            get
            {
                return _workoutLocation;
            }

            set
            {
                _workoutLocation = value;
                RaisePropertyChanged(() => WorkoutLocation);
            }
        }

        #endregion

        #region Constructors

        public AddWorkoutViewModel()
        {

        }

        public AddWorkoutViewModel(IWorkoutsService workoutsService)
        {
            _workoutId = new ValidatableObject<int>() { Value = 0 };
            _workoutDate = new ValidatableObject<DateTime>() { Value = DateTime.Today };
            _workoutLocation = new ValidatableObject<string>() { Value = "Gym" };
            _workoutsService = workoutsService;
        }

        #endregion

        #region Public Methods
        public override async Task InitializeAsync(object navigationData)
        {
            await Task.Delay(1);
        }
        #endregion

        #region Private Methods

        private void AddValidations()
        {
            _workoutId.Validations.Add(new IsNotNullOrEmptyRule<int>
            {
                ValidationMessage = "An id is required"
            });

            _workoutDate.Validations.Add(new IsNotNullOrEmptyRule<DateTime>
            {
                ValidationMessage = "A workout date is required"
            });
        }

        private async Task SaveWorkoutAsync()
        {
            await _workoutsService.SaveWorkoutAsync(_workoutId.Value, _workoutDate.Value, _workoutLocation.Value);
            await NavigateToWorkoutsAsync();
        }

        private async Task NavigateToWorkoutsAsync()
        {
            string dashboard = "yes";
            await NavigationService.NavigateToAsync<MainViewModel>(dashboard);
        }

        #endregion
    }
}
