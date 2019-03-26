using Tasprof.Apps.MyWorkouts.Controls;
using Xamarin.Forms.Platform.WPF;
using Tasprof.Apps.MyWorkouts.Wpf.Renderers;
using System.Windows.Controls;
using System;
using System.ComponentModel;

[assembly: ExportRenderer(typeof(NativeListView), typeof(NativeListViewRenderer))]
namespace Tasprof.Apps.MyWorkouts.Wpf.Renderers
{
    public class NativeListViewRenderer : ListViewRenderer
    {
        ListView listView;

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.ListView> e)
        {
            base.OnElementChanged(e);

            listView = Control as ListView;

            if (e.OldElement != null)
            {
                //unsubscribe
                listView.SelectionChanged -= OnSelectedItemChanged;
            }

            if(e.NewElement != null)
            {
                listView.SelectionMode  = SelectionMode.Single;
                //listView.IsItemClickEnabled = false;
                listView.ItemsSource = ((NativeListView)e.NewElement).Items;
                listView.ItemTemplate = App.Current.Resources["ListViewItemTemplate"] as System.Windows.DataTemplate;

                // Subscribe
                listView.SelectionChanged += OnSelectedItemChanged;
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == NativeListView.ItemsProperty.PropertyName)
            {
                listView.ItemsSource = ((NativeListView)Element).Items;
            }
        }

        private void OnSelectedItemChanged(object sender, SelectionChangedEventArgs e)
        {
            ((NativeListView)Element).NotifyItemSelected(listView.SelectedItem);
        }
    }
}
