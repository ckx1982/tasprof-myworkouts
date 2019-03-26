using Tasprof.Apps.MyWorkouts.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tasprof.Apps.MyWorkouts.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomNavigationView : CustomNavigationPage
    {
        public CustomNavigationView() :base()   
        {
            InitializeComponent();
        }

        public CustomNavigationView(Page root) : base(root)
        {
            InitializeComponent();
        }

    }
}