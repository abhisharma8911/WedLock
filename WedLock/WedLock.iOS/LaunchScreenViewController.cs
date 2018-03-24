using System;
using UIKit;

namespace WedLock.iOS
{
    class LaunchScreenViewController : UIViewController
    {
        public LaunchScreenViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            //SplashImageView.Frame = ParentView.Bounds;
        }
    }
}