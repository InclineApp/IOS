using System;

using UIKit;

namespace InclineApp
{
    public partial class LogViewController : UIViewController
    {
        public LogViewController(IntPtr handle) : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
        }

        partial void UIButton5140_TouchUpInside(UIButton sender)
        {
            //PerformSegue("WWang", this);
        }
    }
}