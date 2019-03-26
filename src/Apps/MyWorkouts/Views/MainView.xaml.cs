using Tasprof.Apps.MyWorkouts.Controls;
using Tasprof.Apps.MyWorkouts.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tasprof.Apps.MyWorkouts.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainView : CustomTabbedPage
	{
		public MainView()
		{
			InitializeComponent();
            BindingContext = new MainViewModel();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await ((WorkoutsViewModel)WorkoutsView.BindingContext).InitializeAsync(null);
        }
    }
}