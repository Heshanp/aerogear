using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Pipe.Callback {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.callback']/class[@name='AbstractCallback']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/callback/AbstractCallback", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class AbstractCallback : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/pipe/callback/AbstractCallback", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractCallback); }
		}

		protected AbstractCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayLjava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.callback']/class[@name='AbstractCallback']/constructor[@name='AbstractCallback' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register (".ctor", "([Ljava/lang/Object;)V", "")]
		public unsafe AbstractCallback (params global:: Java.Lang.Object[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (AbstractCallback)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([Ljava/lang/Object;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([Ljava/lang/Object;)V", __args);
					return;
				}

				if (id_ctor_arrayLjava_lang_Object_ == IntPtr.Zero)
					id_ctor_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "([Ljava/lang/Object;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLjava_lang_Object_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayLjava_lang_Object_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}

	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/callback/AbstractCallback", DoNotGenerateAcw=true)]
	internal partial class AbstractCallbackInvoker : AbstractCallback {

		public AbstractCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractCallbackInvoker); }
		}

	}

}
