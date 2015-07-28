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
	[Protocol (Name = "GIDSignInDelegate", WrapperType = typeof (SignInDelegateWrapper))]
	public interface ISignInDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("signIn:didSignInForUser:withError:")]
		[Preserve (Conditional = true)]
		void DidSignInForUser (SignIn signIn, GoogleUser user, NSError error);
		
	}
	
	public static partial class SignInDelegate_Extensions {
		[CompilerGenerated]
		public static void DidDisconnect (this ISignInDelegate This, SignIn signIn, GoogleUser user, NSError error)
		{
			if (signIn == null)
				throw new ArgumentNullException ("signIn");
			if (user == null)
				throw new ArgumentNullException ("user");
			if (error == null)
				throw new ArgumentNullException ("error");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("signIn:didDisconnectWithUser:withError:"), signIn.Handle, user.Handle, error.Handle);
		}
		
	}
	
	internal sealed class SignInDelegateWrapper : BaseWrapper, ISignInDelegate {
		public SignInDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public SignInDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("signIn:didSignInForUser:withError:")]
		[CompilerGenerated]
		public void DidSignInForUser (SignIn signIn, GoogleUser user, NSError error)
		{
			if (signIn == null)
				throw new ArgumentNullException ("signIn");
			if (user == null)
				throw new ArgumentNullException ("user");
			if (error == null)
				throw new ArgumentNullException ("error");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("signIn:didSignInForUser:withError:"), signIn.Handle, user.Handle, error.Handle);
		}
		
	}
}
namespace Google.SignIn {
	[Protocol]
	[Register("GIDSignInDelegate", false)]
	[Model]
	public unsafe abstract partial class SignInDelegate : NSObject, ISignInDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected SignInDelegate () : base (NSObjectFlag.Empty)
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
		protected SignInDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SignInDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("signIn:didDisconnectWithUser:withError:")]
		[CompilerGenerated]
		public virtual void DidDisconnect (SignIn signIn, GoogleUser user, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("signIn:didSignInForUser:withError:")]
		[CompilerGenerated]
		public abstract void DidSignInForUser (SignIn signIn, GoogleUser user, NSError error);
	} /* class SignInDelegate */
}
