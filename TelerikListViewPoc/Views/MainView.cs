using System.Linq;
using Telerik.XamarinForms.DataControls;
using Telerik.XamarinForms.DataControls.ListView;
using TelerikListViewPoc.Controls;
using TelerikListViewPoc.ViewModels;
using Xamarin.Forms;

namespace TelerikListViewPoc.Views
{
    public class MainView : ContentPage
    {
        public MainView()
        {
            var listView = new ListViewEx 
            {
                ItemTemplate = new DataTemplate(() => 
                {
                    return new BookListCell ();
                }),
                SelectionMode = SelectionMode.None,
                IsItemSwipeEnabled = true,
                IsItemsReorderEnabled = true,
                SwipeThreshold = 70,
                SwipeOffset = new Thickness (70, 0, 2 * 70, 0)
            };
            listView.SetBinding(RadListView.ItemsSourceProperty, nameof(this.ViewModel.Bocks));

            this.Content = listView;
        }

        public MainViewModel ViewModel 
        {
            get { return this.BindingContext as MainViewModel; }
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            this.InitializeToolbar();
        }

        protected override void OnParentSet()
        {
            base.OnParentSet();
            this.InitializeToolbar();
        }

        private void InitializeToolbar()
        {
            if (this.Parent == null || this.ViewModel == null || this.ToolbarItems.Any())
                return;

            var addToolbarItem = new ToolbarItem {
                Text = "Add"
            };
            addToolbarItem.SetBinding(ToolbarItem.CommandProperty, nameof(this.ViewModel.AddCommand));
            this.ToolbarItems.Add(addToolbarItem);
        }
    }
}