using Telerik.XamarinForms.DataControls;
using Telerik.XamarinForms.DataControlsRenderer.iOS;
using TelerikListViewPoc.Controls;
using TelerikUI;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(ListViewEx), typeof(TelerikListViewPoc.iOS.Renderers.ListViewExRenderer))]
namespace TelerikListViewPoc.iOS.Renderers
{
    public class ListViewExRenderer : ListViewRenderer
    {
        protected override void OnElementChanged(Xamarin.Forms.Platform.iOS.ElementChangedEventArgs<RadListView> e)
        {
            base.OnElementChanged(e);

            if (this.Control != null) 
            {
                var layout = (TKListViewLinearLayout)this.Control.Layout;
                layout.ItemAppearAnimation = TKListViewItemAnimation.Scale;
                // layout.ItemInsertAnimation = TKListViewItemAnimation.Scale;
                // layout.ItemDeleteAnimation = TKListViewItemAnimation.Scale;
            }
        }
    }
}
