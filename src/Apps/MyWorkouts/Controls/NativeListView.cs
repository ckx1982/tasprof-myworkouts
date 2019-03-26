using Tasprof.Apps.MyWorkouts.Models;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Tasprof.Apps.MyWorkouts.Controls
{
    public class NativeListView : ListView
    {
        public static readonly BindableProperty ItemsProperty =
          BindableProperty.Create("Items", typeof(IEnumerable<Workout>), typeof(NativeListView), new List<Workout>());

        public IEnumerable<Workout> Items
        {
            get { return (IEnumerable<Workout>)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        public event EventHandler<SelectedItemChangedEventArgs> ItemSelected;

        public void NotifyItemSelected(object item)
        {
            if (ItemSelected != null)
            {
                ItemSelected(this, new SelectedItemChangedEventArgs(item));
            }
        }
    }
}
