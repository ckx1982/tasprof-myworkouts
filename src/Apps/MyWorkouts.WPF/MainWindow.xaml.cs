using Xamarin.Forms.Platform.WPF;
using Xamarin.Forms;

namespace Tasprof.Apps.MyWorkouts.Wpf
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : FormsApplicationPage
    {
        public MainWindow()
        {
            InitializeComponent();
            Forms.Init();
            LoadApplication(new MyWorkouts.App());
        }
    }
}
