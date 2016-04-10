using System;

using UIKit;

namespace InclineApp
{
    public partial class ForgetPasswordViewController : UIViewController
    {
        /// <summary>
        /// Constructs a ForgetPasswordViewController.
        /// </summary>
        /// <param name="handle"></param>
        public ForgetPasswordViewController(IntPtr handle) : base(handle)
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
    }
}