using System;

using UIKit;
using Foundation;

namespace TestApp
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			this.View.BackgroundColor = UIColor.Red;

			this.View.AddGestureRecognizer (new UITapGestureRecognizer (() => {
				if(!UIApplication.SharedApplication.OpenUrl(NSUrl.FromString("testscheme://com.companyname.testinvokeapp?HelloWorld!")))
				{
					Console.WriteLine("app is not exist!");
				}
			}));
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

