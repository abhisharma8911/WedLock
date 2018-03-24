using Xamarin.Forms;

namespace WedLock.Custom
{
    public class CustomEntry : Entry
    {

        #region Underline Property
        public static readonly BindableProperty UnderlineColorProperty = BindableProperty.Create(nameof(UnderlineColor),
            typeof(Xamarin.Forms.Color), typeof(CustomEntry), Xamarin.Forms.Color.Black, BindingMode.TwoWay);
        public Color UnderlineColor
        {
            get { return (Xamarin.Forms.Color)this.GetValue(UnderlineColorProperty); }
            set { this.SetValue(UnderlineColorProperty, value); }
        }
        #endregion

        #region Hide Underline Property

        public static readonly BindableProperty HideUnderlineProperty = BindableProperty.Create(nameof(HideUnderline),
            typeof(bool), typeof(CustomEntry), false, BindingMode.TwoWay);
        public bool HideUnderline
        {
            get { return (bool)this.GetValue(HideUnderlineProperty); }
            set { this.SetValue(HideUnderlineProperty, value); }
        }

        #endregion
    }
}
