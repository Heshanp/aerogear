using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Pipe.Callback {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.callback']/class[@name='AbstractFragmentCallback']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/callback/AbstractFragmentCallback", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class AbstractFragmentCallback : global::Org.Jboss.Aerogear.Android.Pipe.Callback.AbstractCallback {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/pipe/callback/AbstractFragmentCallback", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractFragmentCallback); }
		}

		protected AbstractFragmentCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayLjava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.callback']/class[@name='AbstractFragmentCallback']/constructor[@name='AbstractFragmentCallback' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register (".ctor", "([Ljava/lang/Object;)V", "")]
		public unsafe AbstractFragmentCallback (params global:: Java.Lang.Object[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (AbstractFragmentCallback)) {
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

		static Delegate cb_getFragment;
#pragma warning disable 0169
		static Delegate GetGetFragmentHandler ()
		{
			if (cb_getFragment == null)
				cb_getFragment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFragment);
			return cb_getFragment;
		}

		static IntPtr n_GetFragment (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Callback.AbstractFragmentCallback __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Callback.AbstractFragmentCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Fragment);
		}
#pragma warning restore 0169

		static IntPtr id_getFragment;
		protected virtual unsafe global::Android.App.Fragment Fragment {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.callback']/class[@name='AbstractFragmentCallback']/method[@name='getFragment' and count(parameter)=0]"
			[Register ("getFragment", "()Landroid/app/Fragment;", "GetGetFragmentHandler")]
			get {
				if (id_getFragment == IntPtr.Zero)
					id_getFragment = JNIEnv.GetMethodID (class_ref, "getFragment", "()Landroid/app/Fragment;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.App.Fragment> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFragment), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.App.Fragment> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFragment", "()Landroid/app/Fragment;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setFragment_Landroid_app_Fragment_;
#pragma warning disable 0169
		static Delegate GetSetFragment_Landroid_app_Fragment_Handler ()
		{
			if (cb_setFragment_Landroid_app_Fragment_ == null)
				cb_setFragment_Landroid_app_Fragment_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFragment_Landroid_app_Fragment_);
			return cb_setFragment_Landroid_app_Fragment_;
		}

		static void n_SetFragment_Landroid_app_Fragment_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Callback.AbstractFragmentCallback __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Callback.AbstractFragmentCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Fragment p0 = global::Java.Lang.Object.GetObject<global::Android.App.Fragment> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetFragment (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setFragment_Landroid_app_Fragment_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.callback']/class[@name='AbstractFragmentCallback']/method[@name='setFragment' and count(parameter)=1 and parameter[1][@type='android.app.Fragment']]"
		[Register ("setFragment", "(Landroid/app/Fragment;)V", "GetSetFragment_Landroid_app_Fragment_Handler")]
		public virtual unsafe void SetFragment (global::Android.App.Fragment p0)
		{
			if (id_setFragment_Landroid_app_Fragment_ == IntPtr.Zero)
				id_setFragment_Landroid_app_Fragment_ = JNIEnv.GetMethodID (class_ref, "setFragment", "(Landroid/app/Fragment;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFragment_Landroid_app_Fragment_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFragment", "(Landroid/app/Fragment;)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/callback/AbstractFragmentCallback", DoNotGenerateAcw=true)]
	internal partial class AbstractFragmentCallbackInvoker : AbstractFragmentCallback {

		public AbstractFragmentCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractFragmentCallbackInvoker); }
		}

	}

}
