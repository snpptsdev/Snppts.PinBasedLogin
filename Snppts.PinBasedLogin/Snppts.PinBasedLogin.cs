using System;

using Xamarin.Forms;
using FreshMvvm;

namespace Snppts.PinBasedLogin
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            var navContainer = new FreshNavigationContainer(FreshPageModelResolver.ResolvePageModel<PinLoginPageModel>());
            navContainer.BarTextColor = Color.White;
            MainPage = navContainer;
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

