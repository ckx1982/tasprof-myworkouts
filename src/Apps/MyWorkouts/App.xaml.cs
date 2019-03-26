using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Threading.Tasks;
using Tasprof.Apps.MyWorkouts.ViewModels.Base;
using Tasprof.Apps.MyWorkouts.Services.Navigation;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Tasprof.Apps.MyWorkouts
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            InitNavigation();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        private Task InitNavigation()
        {
            var navigationService = ViewModelLocator.Resolve<INavigationService>();
            return navigationService.InitializeAsync();
        }
    }
}
