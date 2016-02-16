using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace Snppts.PinBasedLogin.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            UIApplication.SharedApplication.SetStatusBarHidden(false, false);
            LoadApplication(new App());

            SetTheme();

            return base.FinishedLaunching(app, options);
        }

        void SetTheme()
        {
            UINavigationBar.Appearance.BarTintColor = UIColor.FromRGB(0, 123, 233);
            UINavigationBar.Appearance.TintColor = UIColor.White;
            UINavigationBar.Appearance.SetTitleTextAttributes(new UITextAttributes()
                {
                    TextColor = UIColor.White
                });
        }
    }
}

