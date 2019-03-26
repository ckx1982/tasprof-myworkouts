using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasprof.Apps.MyWorkouts.Services.User;
using Tasprof.Apps.MyWorkouts.ViewModels;
using Tasprof.Apps.MyWorkouts.ViewModels.Base;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tasprof.Apps.MyWorkouts.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginView : ContentPage
	{
		public LoginView ()
		{
			InitializeComponent ();
            BindingContext = new LoginViewModel(ViewModelLocator.Resolve<IUserService>());
		}
	}
}