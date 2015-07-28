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
	[Protocol (Name = "GIDSignInUIDelegate", WrapperType = typeof (SignInUIDelegateWrapper))]
	public interface ISignInUIDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class SignInUIDelegate_Extensions {
		[CompilerGenerated]
		public static void SignInWillDispatch (this ISignInUIDelegate This, SignIn signIn, NSError error)
		{
			if (signIn == null)
				throw new ArgumentNullException ("signIn");
			if (error == null)
				throw new ArgumentNullException ("error");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("signInWillDispatch:error:"), signIn.Handle, error.Handle);
		}
		
		[CompilerGenerated]
		public static void PresentViewController (this ISignInUIDelegate This, SignIn signIn, global::UIKit.UIViewController viewController)
		{
			if (signIn == null)
				throw new ArgumentNullException ("signIn");
			if (viewController == null)
				throw new ArgumentNullException ("viewController");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("signIn:presentViewController:"), signIn.Handle, viewController.Handle);
		}
		
		[CompilerGenerated]
		public static void DismissViewController (this ISignInUIDelegate This, SignIn signIn, global::UIKit.UIViewController viewController)
		{
			if (signIn == null)
				throw new ArgumentNullException ("signIn");
			if (viewController == null)
				throw new ArgumentNullException ("viewController");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("signIn:dismissViewController:"), signIn.Handle, viewController.Handle);
		}
		
	}
	
	internal sealed class SignInUIDelegateWrapper : BaseWrapper, ISignInUIDelegate {
		public SignInUIDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public SignInUIDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace Google.SignIn {
	[Protocol]
	[Register("GIDSignInUIDelegate", false)]
	[Model]
	public unsafe partial class SignInUIDelegate : NSObject, ISignInUIDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SignInUIDelegate () : base (NSObjectFlag.Empty)
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
		protected SignInUIDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SignInUIDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("signIn:dismissViewController:")]
		[CompilerGenerated]
		public virtual void DismissViewController (SignIn signIn, global::UIKit.UIViewController viewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("signIn:presentViewController:")]
		[CompilerGenerated]
		public virtual void PresentViewController (SignIn signIn, global::UIKit.UIViewController viewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("signInWillDispatch:error:")]
		[CompilerGenerated]
		public virtual void SignInWillDispatch (SignIn signIn, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class SignInUIDelegate */
}
