using Android.Content.Res;
using Android.Graphics;
using Android.OS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


using WedLock.Droid.CustomRenderer;
using WedLock.Custom;
using Android.Views;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace WedLock.Droid.CustomRenderer
{
    public class CustomEntryRenderer:EntryRenderer
    {
        public CustomEntryRenderer() : base()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control == null || e.NewElement == null || !(e.NewElement is CustomEntry entry)) return;

            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
                Control.BackgroundTintList = ColorStateList.ValueOf(ColorExtensions.ToAndroid(entry.UnderlineColor));
            else
                Control.Background.SetColorFilter(ColorExtensions.ToAndroid(entry.UnderlineColor), PorterDuff.Mode.SrcAtop);

            UnderLineVisibilty(entry.HideUnderline);
        }
        private void UnderLineVisibilty(bool underLineVisibilty)
        {
            if (underLineVisibilty)
            {
                Control.SetBackgroundColor(Android.Graphics.Color.Argb(0, 0, 0, 0));
            }
        }
    }
}