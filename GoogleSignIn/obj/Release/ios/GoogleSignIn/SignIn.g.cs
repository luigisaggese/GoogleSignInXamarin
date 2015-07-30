//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using MapKit;
using Security;
using SceneKit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using NewsstandKit;
using AVFoundation;
using CoreAnimation;
using CoreFoundation;

namespace Google.SignIn {
	[Register("GIDSignIn", true)]
	public unsafe partial class SignIn : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("GIDSignIn");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SignIn () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected SignIn (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SignIn (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("checkGoogleSignInAppInstalled:")]
		[CompilerGenerated]
		public unsafe virtual void CheckGoogleSignInAppInstalled ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<bool> callback)
		{
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDActionArity1V0.Handler, callback);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("checkGoogleSignInAppInstalled:"), (IntPtr) block_ptr_callback);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("checkGoogleSignInAppInstalled:"), (IntPtr) block_ptr_callback);
			}
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("disconnect")]
		[CompilerGenerated]
		public virtual void Disconnect ()
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("disconnect"));
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("disconnect"));
			}
		}
		
		[Export ("handleURL:sourceApplication:annotation:")]
		[CompilerGenerated]
		public virtual bool HandleURL (NSUrl url, string sourceApplication, NSObject annotation)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (sourceApplication == null)
				throw new ArgumentNullException ("sourceApplication");
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			var nssourceApplication = NSString.CreateNative (sourceApplication);
			
			bool ret;
			if (IsDirectBinding) {
				ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("handleURL:sourceApplication:annotation:"), url.Handle, nssourceApplication, annotation.Handle);
			} else {
				ret = ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("handleURL:sourceApplication:annotation:"), url.Handle, nssourceApplication, annotation.Handle);
			}
			NSString.ReleaseNative (nssourceApplication);
			
			return ret;
		}
		
		[Export ("signIn")]
		[CompilerGenerated]
		public virtual void Signin ()
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("signIn"));
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("signIn"));
			}
		}
		
		[Export ("signInSilently")]
		[CompilerGenerated]
		public virtual void SignInSilently ()
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("signInSilently"));
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("signInSilently"));
			}
		}
		
		[Export ("signOut")]
		[CompilerGenerated]
		public virtual void SignOut ()
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("signOut"));
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("signOut"));
			}
		}
		
		[CompilerGenerated]
		public virtual bool AllowsSignInWithBrowser {
			[Export ("allowsSignInWithBrowser")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("allowsSignInWithBrowser"));
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("allowsSignInWithBrowser"));
				}
			}
			
			[Export ("setAllowsSignInWithBrowser:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAllowsSignInWithBrowser:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAllowsSignInWithBrowser:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool AllowsSignInWithWebView {
			[Export ("allowsSignInWithWebView")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("allowsSignInWithWebView"));
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("allowsSignInWithWebView"));
				}
			}
			
			[Export ("setAllowsSignInWithWebView:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAllowsSignInWithWebView:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAllowsSignInWithWebView:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string ClientId {
			[Export ("clientID", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("clientID")));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("clientID")));
				}
			}
			
			[Export ("setClientID:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setClientID:"), nsvalue);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setClientID:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_CurrentUser_var;
		[CompilerGenerated]
		public virtual GoogleUser CurrentUser {
			[Export ("currentUser")]
			get {
				GoogleUser ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<GoogleUser> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("currentUser")));
				} else {
					ret =  Runtime.GetNSObject<GoogleUser> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("currentUser")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_CurrentUser_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public ISignInDelegate Delegate {
			get {
				return WeakDelegate as /**/ISignInDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool HasAuthInKeychain {
			[Export ("hasAuthInKeychain")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasAuthInKeychain"));
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hasAuthInKeychain"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Language {
			[Export ("language", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("language")));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("language")));
				}
			}
			
			[Export ("setLanguage:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLanguage:"), nsvalue);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLanguage:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string OpenIDRealm {
			[Export ("openIDRealm")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("openIDRealm")));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("openIDRealm")));
				}
			}
			
			[Export ("setOpenIDRealm:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setOpenIDRealm:"), nsvalue);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setOpenIDRealm:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.String[] Scopes {
			[Export ("scopes", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSArray.StringArrayFromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("scopes")));
				} else {
					return NSArray.StringArrayFromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scopes")));
				}
			}
			
			[Export ("setScopes:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromStrings (value);
				
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setScopes:"), nsa_value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setScopes:"), nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
			}
		}
		
		[CompilerGenerated]
		public virtual string ServerClientID {
			[Export ("serverClientID")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("serverClientID")));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("serverClientID")));
				}
			}
			
			[Export ("setServerClientID:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setServerClientID:"), nsvalue);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setServerClientID:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		static object __mt_SharedInstance_var_static;
		[CompilerGenerated]
		public static SignIn SharedInstance {
			[Export ("sharedInstance")]
			get {
				SignIn ret;
				ret =  Runtime.GetNSObject<SignIn> (ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("sharedInstance")));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_SharedInstance_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool ShouldFetchBasicProfile {
			[Export ("shouldFetchBasicProfile", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldFetchBasicProfile"));
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shouldFetchBasicProfile"));
				}
			}
			
			[Export ("setShouldFetchBasicProfile:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShouldFetchBasicProfile:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShouldFetchBasicProfile:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public ISignInUIDelegate UiDelegate {
			get {
				return WeakUiDelegate as /**/ISignInUIDelegate;
			}
			set {
				WeakUiDelegate = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual ISignInDelegate WeakDelegate {
			[Export ("delegate", ArgumentSemantic.UnsafeUnretained)]
			get {
				ISignInDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<ISignInDelegate> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false);
				} else {
					ret =  Runtime.GetINativeObject<ISignInDelegate> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")), false);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_WeakUiDelegate_var;
		[CompilerGenerated]
		public virtual ISignInUIDelegate WeakUiDelegate {
			[Export ("uiDelegate", ArgumentSemantic.UnsafeUnretained)]
			get {
				ISignInUIDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<ISignInUIDelegate> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("uiDelegate")), false);
				} else {
					ret =  Runtime.GetINativeObject<ISignInUIDelegate> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("uiDelegate")), false);
				}
				MarkDirty ();
				__mt_WeakUiDelegate_var = ret;
				return ret;
			}
			
			[Export ("setUiDelegate:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUiDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUiDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakUiDelegate_var = value;
			}
		}
		
		//
		// Events and properties from the delegate
		//
		
		_SignInDelegate EnsureSignInDelegate ()
		{
			var del = Delegate;
			if (del == null || (!(del is _SignInDelegate))){
				del = new _SignInDelegate ();
				Delegate = del;
			}
			return (_SignInDelegate) del;
		}
		
		#pragma warning disable 672
		[Register]
		sealed class _SignInDelegate : Google.SignIn.SignInDelegate { 
			public _SignInDelegate () { IsDirectBinding = false; }
			
			internal EventHandler<SignInDelegateDidDisconnectEventArgs> didDisconnect;
			[Preserve (Conditional = true)]
			public override void DidDisconnect (Google.SignIn.SignIn signIn, Google.SignIn.GoogleUser user, NSError error)
			{
				EventHandler<SignInDelegateDidDisconnectEventArgs> handler = didDisconnect;
				if (handler != null){
					var args = new SignInDelegateDidDisconnectEventArgs (user, error);
					handler (signIn, args);
				}
			}
			
			internal EventHandler<SignInDelegateDidSignInForUserEventArgs> didSignInForUser;
			[Preserve (Conditional = true)]
			public override void DidSignInForUser (Google.SignIn.SignIn signIn, Google.SignIn.GoogleUser user, NSError error)
			{
				EventHandler<SignInDelegateDidSignInForUserEventArgs> handler = didSignInForUser;
				if (handler != null){
					var args = new SignInDelegateDidSignInForUserEventArgs (user, error);
					handler (signIn, args);
				}
			}
			
		}
		#pragma warning restore 672
		_SignInUIDelegate EnsureSignInUIDelegate ()
		{
			var del = UiDelegate;
			if (del == null || (!(del is _SignInUIDelegate))){
				del = new _SignInUIDelegate ();
				UiDelegate = del;
			}
			return (_SignInUIDelegate) del;
		}
		
		#pragma warning disable 672
		[Register]
		sealed class _SignInUIDelegate : Google.SignIn.SignInUIDelegate { 
			public _SignInUIDelegate () { IsDirectBinding = false; }
			
			internal EventHandler<SignInUIDelegateDismissViewControllerEventArgs> dismissViewController;
			[Preserve (Conditional = true)]
			public override void DismissViewController (Google.SignIn.SignIn signIn, UIViewController viewController)
			{
				EventHandler<SignInUIDelegateDismissViewControllerEventArgs> handler = dismissViewController;
				if (handler != null){
					var args = new SignInUIDelegateDismissViewControllerEventArgs (viewController);
					handler (signIn, args);
				}
			}
			
			internal EventHandler<SignInUIDelegatePresentViewControllerEventArgs> presentViewController;
			[Preserve (Conditional = true)]
			public override void PresentViewController (Google.SignIn.SignIn signIn, UIViewController viewController)
			{
				EventHandler<SignInUIDelegatePresentViewControllerEventArgs> handler = presentViewController;
				if (handler != null){
					var args = new SignInUIDelegatePresentViewControllerEventArgs (viewController);
					handler (signIn, args);
				}
			}
			
			internal EventHandler<SignInUIDelegateSignInWillDispatchEventArgs> signInWillDispatch;
			[Preserve (Conditional = true)]
			public override void SignInWillDispatch (Google.SignIn.SignIn signIn, NSError error)
			{
				EventHandler<SignInUIDelegateSignInWillDispatchEventArgs> handler = signInWillDispatch;
				if (handler != null){
					var args = new SignInUIDelegateSignInWillDispatchEventArgs (error);
					handler (signIn, args);
				}
			}
			
		}
		#pragma warning restore 672
		
		public event EventHandler<SignInDelegateDidDisconnectEventArgs> DidDisconnect {
			add { EnsureSignInDelegate ().didDisconnect += value; }
			remove { EnsureSignInDelegate ().didDisconnect -= value; }
		}
		
		public event EventHandler<SignInDelegateDidSignInForUserEventArgs> DidSignInForUser {
			add { EnsureSignInDelegate ().didSignInForUser += value; }
			remove { EnsureSignInDelegate ().didSignInForUser -= value; }
		}
		
		public event EventHandler<SignInUIDelegateDismissViewControllerEventArgs> DismissViewController {
			add { EnsureSignInUIDelegate ().dismissViewController += value; }
			remove { EnsureSignInUIDelegate ().dismissViewController -= value; }
		}
		
		public event EventHandler<SignInUIDelegatePresentViewControllerEventArgs> PresentViewController {
			add { EnsureSignInUIDelegate ().presentViewController += value; }
			remove { EnsureSignInUIDelegate ().presentViewController -= value; }
		}
		
		public event EventHandler<SignInUIDelegateSignInWillDispatchEventArgs> SignInWillDispatch {
			add { EnsureSignInUIDelegate ().signInWillDispatch += value; }
			remove { EnsureSignInUIDelegate ().signInWillDispatch -= value; }
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_CurrentUser_var = null;
				__mt_WeakDelegate_var = null;
				__mt_WeakUiDelegate_var = null;
			}
		}
	} /* class SignIn */
	
	
	//
	// EventArgs classes
	//
	public partial class SignInDelegateDidDisconnectEventArgs : EventArgs {
		public SignInDelegateDidDisconnectEventArgs (Google.SignIn.GoogleUser user, NSError error)
		{
			this.Error = error;
			this.User = user;
		}
		public NSError Error { get; set; }
		public Google.SignIn.GoogleUser User { get; set; }
	}
	
	public partial class SignInDelegateDidSignInForUserEventArgs : EventArgs {
		public SignInDelegateDidSignInForUserEventArgs (Google.SignIn.GoogleUser user, NSError error)
		{
			this.Error = error;
			this.User = user;
		}
		public NSError Error { get; set; }
		public Google.SignIn.GoogleUser User { get; set; }
	}
	
	public partial class SignInUIDelegateDismissViewControllerEventArgs : EventArgs {
		public SignInUIDelegateDismissViewControllerEventArgs (UIViewController viewController)
		{
			this.ViewController = viewController;
		}
		public UIViewController ViewController { get; set; }
	}
	
	public partial class SignInUIDelegatePresentViewControllerEventArgs : EventArgs {
		public SignInUIDelegatePresentViewControllerEventArgs (UIViewController viewController)
		{
			this.ViewController = viewController;
		}
		public UIViewController ViewController { get; set; }
	}
	
	public partial class SignInUIDelegateSignInWillDispatchEventArgs : EventArgs {
		public SignInUIDelegateSignInWillDispatchEventArgs (NSError error)
		{
			this.Error = error;
		}
		public NSError Error { get; set; }
	}
	
}
