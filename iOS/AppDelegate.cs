using System;
using Foundation;
using Telerik.XamarinForms.Common.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer (typeof (Telerik.XamarinForms.DataControls.RadListView), typeof (Telerik.XamarinForms.DataControlsRenderer.iOS.ListViewRenderer))]

namespace TelerikListViewPoc.iOS
{
    [Register ("AppDelegate")]
    public class AppDelegate : FormsApplicationDelegate
    {
        public override bool FinishedLaunching (UIApplication uiApplication, NSDictionary launchOptions)
        {
            Forms.Init ();

            this.InitializePlugin<Telerik.XamarinForms.DataControlsRenderer.iOS.ListViewRenderer> ();

            TelerikForms.Init();

            LoadApplication(new App());

            return base.FinishedLaunching (uiApplication, launchOptions);
        }

        private void InitializePlugin<TPlugin>() where TPlugin : class
        {
            Activator.CreateInstance<TPlugin>();
        }
    }
}
