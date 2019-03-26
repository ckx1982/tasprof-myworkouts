using Tasprof.Apps.MyWorkouts.Controls;
using Tasprof.Apps.MyWorkouts.Wpf.Renderers;
using System.Windows.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;


[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace Tasprof.Apps.MyWorkouts.Wpf.Renderers
{
    public class CustomEntryRenderer: EntryRenderer
    {
        public CustomEntryRenderer(): base()
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Background = Brushes.LightBlue;
            }
        }
    }
}
