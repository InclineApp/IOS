using System;

using UIKit;

namespace InclineApp
{
    public partial class ThingViewController : UIViewController
    {
        public ThingViewController(IntPtr handle) : base(handle)
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


        partial void UIButton1211_TouchUpInside(UIButton sender)
        {
            UIAlertView v = new UIAlertView("Hi", "What's up?", null, "Ok");
            v.Show(); 
        }
    }
}