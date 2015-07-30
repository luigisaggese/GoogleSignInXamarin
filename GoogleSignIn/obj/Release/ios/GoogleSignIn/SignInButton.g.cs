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
	[Register("GIDSignInButton", true)]
	public unsafe partial class SignInButton : global::UIKit.UIButton {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("GIDSignInButton");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SignInButton () : base (NSObjectFlag.Empty)
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
		[Export ("initWithCoder:")]
		public SignInButton (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected SignInButton (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SignInButton (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual GIDSignInButtonColorScheme ColorScheme {
			[Export ("colorScheme", ArgumentSemantic.UnsafeUnretained)]
			get {
				GIDSignInButtonColorScheme ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (GIDSignInButtonColorScheme) ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("colorScheme"));
					} else {
						ret = (GIDSignInButtonColorScheme) ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("colorScheme"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (GIDSignInButtonColorScheme) ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("colorScheme"));
					} else {
						ret = (GIDSignInButtonColorScheme) ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("colorScheme"));
					}
				}
				return ret;
			}
			
			[Export ("setColorScheme:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setColorScheme:"), (Int64)value);
					} else {
						ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setColorScheme:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setColorScheme:"), (Int64)value);
					} else {
						ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setColorScheme:"), (int)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public global::UIKit.UIViewController Delegate {
			get {
				return WeakDelegate as /**/global::UIKit.UIViewController;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		public virtual GIDSignInButtonStyle Style {
			[Export ("style", ArgumentSemantic.UnsafeUnretained)]
			get {
				GIDSignInButtonStyle ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (GIDSignInButtonStyle) ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("style"));
					} else {
						ret = (GIDSignInButtonStyle) ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("style"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (GIDSignInButtonStyle) ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("style"));
					} else {
						ret = (GIDSignInButtonStyle) ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("style"));
					}
				}
				return ret;
			}
			
			[Export ("setStyle:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setStyle:"), (Int64)value);
					} else {
						ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setStyle:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setStyle:"), (Int64)value);
					} else {
						ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setStyle:"), (int)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
				} else {
					ret = Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
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
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class SignInButton */
}
