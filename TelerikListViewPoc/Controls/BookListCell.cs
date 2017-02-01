using System.Diagnostics;
using Telerik.XamarinForms.DataControls.ListView;
using TelerikListViewPoc.Components;
using Xamarin.Forms;

namespace TelerikListViewPoc.Controls
{
    public class BookListCell : ListViewTemplateCell
    {
        public BookListCell()
        {
            var titleLabel = new Label 
            {
                FontSize = Device.GetNamedSize(NamedSize.Default, typeof(Label))
            };
            titleLabel.SetBinding (Label.TextProperty, nameof(this.DataContext.Title), BindingMode.OneWay);
            var authorLabel = new Label 
            {
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label))
            };
            authorLabel.SetBinding (Label.TextProperty, nameof(this.DataContext.Author), BindingMode.OneWay);
            var yearLabel = new Label 
            {
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label))
            };
            yearLabel.SetBinding(Label.TextProperty, nameof(this.DataContext.Year), BindingMode.OneWay);

            var viewLayout = new StackLayout 
            {
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children = { titleLabel, authorLabel, yearLabel },
                HeightRequest = 100
            };

            this.View = viewLayout;
        }

        public Book DataContext 
        {
            get { return this.BindingContext as Book; }
        }

        protected override void OnAppearing()
        {
            Debug.WriteLine("OnAppearing");
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            Debug.WriteLine("OnDisappearing");
            base.OnDisappearing();
        }
    }
}
