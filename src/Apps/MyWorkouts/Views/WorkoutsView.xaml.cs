using Tasprof.Apps.MyWorkouts.Interfaces;
using Tasprof.Apps.MyWorkouts.ViewModels;
using Tasprof.Apps.MyWorkouts.ViewModels.Base;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tasprof.Apps.MyWorkouts.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WorkoutsView : ContentPage
	{
		public WorkoutsView()
		{
            // create contract implementation
			InitializeComponent();
            BindingContext = new WorkoutsViewModel(ViewModelLocator.Resolve<IWorkoutsService>());
		}
	}
}