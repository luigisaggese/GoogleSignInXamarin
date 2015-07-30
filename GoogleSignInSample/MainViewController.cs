using System;

using UIKit;
using Google.SignIn;
using System.Drawing;

namespace GoogleSignInSample
{
	public class MainViewController : UIViewController, ISignInUIDelegate
	{
		SignInButton btnSignIn;

		public MainViewController () : base ()
		{
			Title = "Google SignIn Sample";
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			View.BackgroundColor = UIColor.White;

			btnSignIn = new SignInButton () {
				Frame = new RectangleF (85, 176, 151, 48)
			};
			SignIn.SharedInstance.UiDelegate=this;
			View.AddSubview (btnSignIn);
		}
	}
}

