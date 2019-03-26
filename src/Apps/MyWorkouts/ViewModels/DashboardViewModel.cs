using Tasprof.Apps.MyWorkouts.ViewModels.Base;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Tasprof.Apps.MyWorkouts.ViewModels
{
    public class DashboardViewModel: ViewModelBase
    {
        private int _NumberOfWorkouts;
        public int NumberOfWorkouts
        {
            get
            {
                return _NumberOfWorkouts;
            }
            set
            {
                _NumberOfWorkouts = value;
                RaisePropertyChanged(() => NumberOfWorkouts);
            }
        }

        public ICommand UpdateDashboardCommand => new Command(async() => await UpdateDashboardAsync());

        public DashboardViewModel()
        {

        }

        private async Task UpdateDashboardAsync()
        {
            await Task.Delay(1);
            NumberOfWorkouts = 125;
        }
    }
}
