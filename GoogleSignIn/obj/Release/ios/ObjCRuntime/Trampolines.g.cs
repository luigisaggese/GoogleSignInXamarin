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

namespace ObjCRuntime {
	
	[CompilerGenerated]
	static partial class Trampolines {
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern IntPtr _Block_copy (IntPtr ptr);
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern void _Block_release (IntPtr ptr);
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DGIDAccessTokenHandler (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDGIDAccessTokenHandler {
			static internal readonly DGIDAccessTokenHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DGIDAccessTokenHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Google.SignIn.GIDAccessTokenHandler) (descriptor->Target);
				if (del != null)
					del (NSString.FromHandle (arg0),  Runtime.GetNSObject<Foundation.NSError> (arg1));
			}
		} /* class SDGIDAccessTokenHandler */
		
		internal class NIDGIDAccessTokenHandler {
			IntPtr blockPtr;
			DGIDAccessTokenHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDGIDAccessTokenHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DGIDAccessTokenHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDGIDAccessTokenHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Google.SignIn.GIDAccessTokenHandler Create (IntPtr block)
			{
				return new NIDGIDAccessTokenHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (string arg0, NSError arg1)
			{
				var nsarg0 = NSString.CreateNative (arg0);
				
				invoker (blockPtr, nsarg0, arg1 == null ? IntPtr.Zero : arg1.Handle);
				NSString.ReleaseNative (nsarg0);
				
			}
		} /* class NIDGIDAccessTokenHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DActionArity1V0 (IntPtr block, bool obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V0 {
			static internal readonly DActionArity1V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V0))]
			static unsafe void Invoke (IntPtr block, bool obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<bool>) (descriptor->Target);
				if (del != null)
					del (obj);
			}
		} /* class SDActionArity1V0 */
		
		internal class NIDActionArity1V0 {
			IntPtr blockPtr;
			DActionArity1V0 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity1V0 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity1V0> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity1V0 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<bool> Create (IntPtr block)
			{
				return new NIDActionArity1V0 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (bool obj)
			{
				invoker (blockPtr, obj);
			}
		} /* class NIDActionArity1V0 */
	}
}
