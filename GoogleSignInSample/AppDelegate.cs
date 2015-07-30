using Foundation;
using UIKit;
using Google.SignIn;

namespace GoogleSignInSample
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
	[Register ("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate, ISignInDelegate
	{
		// class-level declarations
		UIWindow window;
		MainViewController viewController;
		UINavigationController navController;


		const string ClientId = "yourclient-id.apps.googleusercontent.com";

		public void DidSignInForUser (SignIn signIn, GoogleUser user, NSError error)
		{
			throw new System.NotImplementedException ();
		}

		public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
		{
			window = new UIWindow (UIScreen.MainScreen.Bounds);

			// Configure the SignIn shared singleton instance by declaring 
			// its client ID, delegate, and scopes.
			SignIn.SharedInstance.Delegate = this;
			var signIn = SignIn.SharedInstance;
			signIn.ClientId = ClientId;
			signIn.Scopes = new [] {Constants.AuthScopeLogin, Constants.AuthScopeMe };

			// If you want to know user Email or Google User Id you should
			// Set ShouldFetchGoogleUserEmail or ShouldFetchGoogleUserId
			// value to true, default value is false
			signIn.ShouldFetchBasicProfile = true;
			signIn.AllowsSignInWithWebView = false;
			viewController = new MainViewController ();
			navController = new UINavigationController (viewController);

			window.RootViewController = navController;
			window.MakeKeyAndVisible ();

			return true;
		}


		public override bool OpenUrl (UIApplication application, NSUrl url, string sourceApplication, NSObject annotation)
		{
			// This handler will properly handle the URL that your application 
			// receives at the end of the authentication process.
			return SignIn.SharedInstance.HandleURL (url, sourceApplication, annotation);
		}					
	}
}


