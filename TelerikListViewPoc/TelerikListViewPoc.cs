using TelerikListViewPoc.ViewModels;
using TelerikListViewPoc.Views;
using Xamarin.Forms;

namespace TelerikListViewPoc
{
    public class App : Application
    {
        public App ()
        {
            // The root page of your application
            var content = new MainView 
            {
                Title = "Telerik ListView POC",
                BindingContext = new MainViewModel()
            };

            this.MainPage = new NavigationPage(content);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}