using Tasprof.Apps.MyWorkouts.Controls;
using Tasprof.Apps.MyWorkouts.Wpf.Renderers;
using System.Windows.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;
using System.Windows;
using System.Windows.Controls;
using System;
using Tasprof.Apps.MyWorkouts.WPF.Renderers.Templates;

[assembly: ExportRenderer(typeof(CustomTabbedPage), typeof(CustomTabbedPageRenderer))]
namespace Tasprof.Apps.MyWorkouts.Wpf.Renderers
{
    public class CustomTabbedPageRenderer: TabbedPageRenderer
    {
        public CustomTabbedPageRenderer(): base()
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<TabbedPage> e)
        {
            base.OnElementChanged(e);



            var controlTemplate = Control.Template;
            var templateContent = controlTemplate.Template;



            if (Control == null)
            {
                // Create the native control and use SetNativeControl
                // Do not assign directly to the Control property unless you know what you are doing
            }

            if (e.OldElement != null)
            {
                // Cleanup resources and remove event handlers for this element.
            }

            if (e.NewElement != null)
            {
                // Use the properties of this element to assign to the native control, which is assigned to the base.Control property
            }

            Control.Loaded += ControlOnLoaded;

        }


        private void ControlOnLoaded(object sender, RoutedEventArgs routedEventArgs)
        {
            //if (((Control.LightContentControl.Parent as System.Windows.Controls.Grid)?.Children[0] as System.Windows.Controls.Grid)?.Children[0] is ListBox listBox)
            //{
                
            //    listBox.ItemTemplate = new System.Windows.DataTemplate { VisualTree = new FrameworkElementFactory(typeof(TabItemTemplate)) };
            //}
            //else
            //{
            //    Console.WriteLine("BadgePlugin: Was not able to find tab bar. Badges not added.");
            //}
        }

    }
}
