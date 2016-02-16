using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Android.Graphics;
using Snppts.PinBasedLogin.Droid;

[assembly:ExportRenderer(typeof(Label), typeof(CustomLabelRenderer))]
namespace Snppts.PinBasedLogin.Droid
{
    public class CustomLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (!string.IsNullOrEmpty(e.NewElement?.FontFamily))
            {
                try
                {
                    var font = Typeface.CreateFromAsset(Forms.Context.ApplicationContext.Assets, e.NewElement.FontFamily + ".ttf");

                    if (font != null)
                    {
                        Control.Typeface = font;
                    }
                }
                catch (Exception ex)
                {
                    // Ignore it, means we couldn't find the asset.
                }
            }
        }
    }
}


