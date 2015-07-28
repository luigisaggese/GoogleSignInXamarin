using System;
using Foundation;
using ObjCRuntime;
using UIKit;
using System.Drawing;

namespace Google.SignIn
{
	// typedef void (^GIDAccessTokenHandler)(NSString *NSError *);
	public delegate void GIDAccessTokenHandler (string arg0, NSError arg1);

	// @interface GIDAuthentication : NSObject <NSCoding>
	[BaseType (typeof(NSObject), Name = "GIDAuthentication")]
	public interface Authentication : INSCoding
	{
		// @property (readonly, nonatomic) NSString * clientID;
		[Export ("clientID")]
		string ClientID { get; }

		// @property (readonly, nonatomic) NSString * accessToken;
		[Export ("accessToken")]
		string AccessToken { get; }

		// @property (readonly, nonatomic) NSDate * accessTokenExpirationDate;
		[Export ("accessTokenExpirationDate")]
		NSDate AccessTokenExpirationDate { get; }

		// @property (readonly, nonatomic) NSString * refreshToken;
		[Export ("refreshToken")]
		string RefreshToken { get; }

		// @property (readonly, nonatomic) NSString * idToken;
		[Export ("idToken")]
		string IdToken { get; }

		// -(void)getAccessTokenWithHandler:(GIDAccessTokenHandler)handler;
		[Export ("getAccessTokenWithHandler:")]
		void GetAccessTokenWithHandler (GIDAccessTokenHandler handler);

		// -(void)refreshAccessTokenWithHandler:(GIDAccessTokenHandler)handler;
		[Export ("refreshAccessTokenWithHandler:")]
		void RefreshAccessTokenWithHandler (GIDAccessTokenHandler handler);
	}

	// @interface GIDGoogleUser : NSObject <NSCoding>
	[BaseType (typeof(NSObject), Name = "GIDGoogleUser")]
	public interface GoogleUser : INSCoding
	{
		// @property (readonly, nonatomic) NSString * userID;
		[Export ("userID")]
		string UserID { get; }

		// @property (readonly, nonatomic) GIDProfileData * profile;
		[Export ("profile")]
		ProfileData Profile { get; }

		// @property (readonly, nonatomic) GIDAuthentication * authentication;
		[Export ("authentication")]
		Authentication Authentication { get; }

		// @property (readonly, nonatomic) NSArray * accessibleScopes;
		[Export ("accessibleScopes")]
		NSObject[] AccessibleScopes { get; }

		// @property (readonly, nonatomic) NSString * hostedDomain;
		[Export ("hostedDomain")]
		string HostedDomain { get; }

		// @property (readonly, nonatomic) NSString * serverAuthCode;
		[Export ("serverAuthCode")]
		string ServerAuthCode { get; }
	}

	// @interface GIDProfileData : NSObject <NSCoding>
	[BaseType (typeof(NSObject),Name = "GIDProfileData")]
	public interface ProfileData : INSCoding
	{
		// @property (readonly, nonatomic) NSString * email;
		[Export ("email")]
		string Email { get; }

		// @property (readonly, nonatomic) NSString * name;
		[Export ("name")]
		string Name { get; }

		// @property (readonly, nonatomic) BOOL hasImage;
		[Export ("hasImage")]
		bool HasImage { get; }

		// -(NSURL *)imageURLWithDimension:(NSUInteger)dimension;
		[Export ("imageURLWithDimension:")]
		NSUrl ImageURLWithDimension (nuint dimension);
	}

	partial interface Constants
	{
		// extern NSString *const kGIDSignInErrorDomain;
		[Field ("kGIDSignInErrorDomain")]
		NSString kGIDSignInErrorDomain { get; }
	}

	// @protocol GIDSignInDelegate

	[BaseType (typeof (NSObject), Name = "GIDSignInDelegate")]
	[Protocol]
	[Model]	
	public interface SignInDelegate
	{
		// @required -(void)signIn:(GIDSignIn *)signIn didSignInForUser:(GIDGoogleUser *)user withError:(NSError *)error;
		[Abstract]
		[Export ("signIn:didSignInForUser:withError:"), EventArgs ("SignInDelegateDidSignInForUser")]
		void DidSignInForUser (SignIn signIn, GoogleUser user, NSError error);

		// @optional -(void)signIn:(GIDSignIn *)signIn didDisconnectWithUser:(GIDGoogleUser *)user withError:(NSError *)error;
		[Export ("signIn:didDisconnectWithUser:withError:"), EventArgs ("SignInDelegateDidDisconnect")]
		void DidDisconnect (SignIn signIn, GoogleUser user, NSError error);
	}



	// @protocol GIDSignInUIDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject), Name = "GIDSignInUIDelegate")]
	public interface SignInUIDelegate
	{
		// @optional -(void)signInWillDispatch:(GIDSignIn *)signIn error:(NSError *)error;
		[Export ("signInWillDispatch:error:"),EventArgs ("SignInUIDelegateSignInWillDispatch")]
		void SignInWillDispatch (SignIn signIn, NSError error);

		// @optional -(void)signIn:(GIDSignIn *)signIn presentViewController:(UIViewController *)viewController;
		[Export ("signIn:presentViewController:"),EventArgs ("SignInUIDelegatePresentViewController")]
		void PresentViewController (SignIn signIn, UIViewController viewController);

		// @optional -(void)signIn:(GIDSignIn *)signIn dismissViewController:(UIViewController *)viewController;
		[Export ("signIn:dismissViewController:"),EventArgs ("SignInUIDelegateDismissViewController")]
		void DismissViewController (SignIn signIn, UIViewController viewController);
	}

	// @interface GIDSignIn : NSObject
	[BaseType (typeof (NSObject), Name="GIDSignIn"
		,Delegates= new string [] {"WeakDelegate","WeakUiDelegate"},
		Events=new Type [] { typeof (SignInDelegate),typeof (SignInUIDelegate)}
	)]
	public interface SignIn
	{
		// @property (readonly, nonatomic) GIDGoogleUser * currentUser;
		[Export ("currentUser")]
		GoogleUser CurrentUser { get; }

		[Wrap ("WeakDelegate")][NullAllowed]
		SignInDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<GIDSignInDelegate> delegate;
		[Export ("delegate", ArgumentSemantic.Weak)][NullAllowed]
		NSObject WeakDelegate { get; set; }

		[Wrap ("WeakUiDelegate")][NullAllowed]
		SignInUIDelegate UiDelegate { get; set; }

		// @property (nonatomic, weak) id<GIDSignInUIDelegate> uiDelegate;

		[Export ("uiDelegate", ArgumentSemantic.Weak)][NullAllowed]
		NSObject WeakUiDelegate { get; set; }

		// @property (copy, nonatomic) NSString * clientID;
		[Export ("clientID", ArgumentSemantic.Copy)]
		string ClientId { get; set; }

		// @property (copy, nonatomic) NSArray * scopes;
		[Export ("scopes", ArgumentSemantic.Copy)]
		string [] Scopes { get; set; }

		// @property (assign, nonatomic) BOOL shouldFetchBasicProfile;
		[Export ("shouldFetchBasicProfile", ArgumentSemantic.Assign)]
		bool ShouldFetchBasicProfile { get; set; }

		// @property (assign, nonatomic) BOOL allowsSignInWithBrowser;
		[Export ("allowsSignInWithBrowser")]
		bool AllowsSignInWithBrowser { get; set; }

		// @property (assign, nonatomic) BOOL allowsSignInWithWebView;
		[Export ("allowsSignInWithWebView")]
		bool AllowsSignInWithWebView { get; set; }

		// @property (copy, nonatomic) NSString * language;
		[Export ("language", ArgumentSemantic.Copy)]
		string Language { get; set; }
	
		// @property (copy, nonatomic) NSString * serverClientID;
		[Export ("serverClientID")]
		string ServerClientID { get; set; }

		// @property (copy, nonatomic) NSString * openIDRealm;
		[Export ("openIDRealm")]
		string OpenIDRealm { get; set; }

		// +(GIDSignIn *)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		SignIn SharedInstance { get; }

		// -(BOOL)handleURL:(NSURL *)url sourceApplication:(NSString *)sourceApplication annotation:(id)annotation;
		[Export ("handleURL:sourceApplication:annotation:")]
		bool HandleURL (NSUrl url, string sourceApplication, NSObject annotation);

		// -(BOOL)hasAuthInKeychain;
		[Export ("hasAuthInKeychain")]
		bool HasAuthInKeychain { get; }

		// -(void)signInSilently;
		[Export ("signInSilently")]
		void SignInSilently ();

		// -(void)signIn;
		[Export ("signIn")]
		void Signin ();

		// -(void)signOut;
		[Export ("signOut")]
		void SignOut ();

		// -(void)disconnect;
		[Export ("disconnect")]
		void Disconnect ();

		// -(void)checkGoogleSignInAppInstalled:(void (^)(BOOL))callback;
		[Export ("checkGoogleSignInAppInstalled:")]
		void CheckGoogleSignInAppInstalled (Action<bool> callback);
	}


	// @interface GIDSignInButton : UIControl
	[BaseType (typeof(UIButton), Name="GIDSignInButton")]
	interface SignInButton
	{
		// @property (assign, nonatomic) GIDSignInButtonStyle style;
		[Export ("style", ArgumentSemantic.Assign)]
		GIDSignInButtonStyle Style { get; set; }

		// @property (assign, nonatomic) GIDSignInButtonColorScheme colorScheme;
		[Export ("colorScheme", ArgumentSemantic.Assign)]
		GIDSignInButtonColorScheme ColorScheme { get; set; }

		[Wrap ("WeakDelegate")]
		UIViewController Delegate { get; set; }

		// @property (nonatomic, weak) UIViewController * delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }
	}

	// @interface GIDSignIn (UIViewController)
	[Category]
	[BaseType (typeof(UIViewController))]
	interface UIViewController_GIDSignIn
	{
		// -(void)gid_signInWithGoogle;
		[Export ("gid_signInWithGoogle")]
		void Gid_signInWithGoogle ();
	}

}

