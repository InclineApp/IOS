using System;

using UIKit;

namespace InclineApp
{
    public partial class FirstViewController : UIViewController
    {
        
        public FirstViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            PerformSegue("Wang", this);
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't  in use.
        }
        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
           

        }
    }
}