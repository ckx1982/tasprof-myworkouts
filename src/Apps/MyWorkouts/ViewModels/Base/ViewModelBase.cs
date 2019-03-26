using Tasprof.Apps.MyWorkouts.Services.Navigation;
using System.Threading.Tasks;

namespace Tasprof.Apps.MyWorkouts.ViewModels.Base
{
    public abstract class ViewModelBase : ExtendedBindableObject
    {

        private bool _isBusy;

        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
                RaisePropertyChanged(() => IsBusy);
            }
        }

        protected readonly INavigationService NavigationService;

        public ViewModelBase()
        {
            NavigationService = ViewModelLocator.Resolve<INavigationService>();
        }

        public virtual Task InitializeAsync(object navigationData)
        {
            return Task.FromResult(false);
        }


    }
}
