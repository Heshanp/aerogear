using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Pipe.Callback {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.callback']/class[@name='AbstractSupportFragmentCallback']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/callback/AbstractSupportFragmentCallback", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class AbstractSupportFragmentCallback : global::Org.Jboss.Aerogear.Android.Pipe.Callback.AbstractCallback {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/pipe/callback/AbstractSupportFragmentCallback", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractSupportFragmentCallback); }
		}

		protected AbstractSupportFragmentCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayLjava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.callback']/class[@name='AbstractSupportFragmentCallback']/constructor[@name='AbstractSupportFragmentCallback' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register (".ctor", "([Ljava/lang/Object;)V", "")]
		public unsafe AbstractSupportFragmentCallback (params global:: Java.Lang.Object[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (AbstractSupportFragmentCallback)) {
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

		static Delegate cb_getSupportFragment;
#pragma warning disable 0169
		static Delegate GetGetSupportFragmentHandler ()
		{
			if (cb_getSupportFragment == null)
				cb_getSupportFragment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSupportFragment);
			return cb_getSupportFragment;
		}

		static IntPtr n_GetSupportFragment (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Callback.AbstractSupportFragmentCallback __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Callback.AbstractSupportFragmentCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SupportFragment);
		}
#pragma warning restore 0169

		static IntPtr id_getSupportFragment;
		protected virtual unsafe global::Android.Support.V4.App.Fragment SupportFragment {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.callback']/class[@name='AbstractSupportFragmentCallback']/method[@name='getSupportFragment' and count(parameter)=0]"
			[Register ("getSupportFragment", "()Landroid/support/v4/app/Fragment;", "GetGetSupportFragmentHandler")]
			get {
				if (id_getSupportFragment == IntPtr.Zero)
					id_getSupportFragment = JNIEnv.GetMethodID (class_ref, "getSupportFragment", "()Landroid/support/v4/app/Fragment;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Support.V4.App.Fragment> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSupportFragment), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Support.V4.App.Fragment> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSupportFragment", "()Landroid/support/v4/app/Fragment;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setSupportFragment_Landroid_support_v4_app_Fragment_;
#pragma warning disable 0169
		static Delegate GetSetSupportFragment_Landroid_support_v4_app_Fragment_Handler ()
		{
			if (cb_setSupportFragment_Landroid_support_v4_app_Fragment_ == null)
				cb_setSupportFragment_Landroid_support_v4_app_Fragment_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSupportFragment_Landroid_support_v4_app_Fragment_);
			return cb_setSupportFragment_Landroid_support_v4_app_Fragment_;
		}

		static void n_SetSupportFragment_Landroid_support_v4_app_Fragment_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Callback.AbstractSupportFragmentCallback __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Callback.AbstractSupportFragmentCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.App.Fragment p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App.Fragment> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSupportFragment (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSupportFragment_Landroid_support_v4_app_Fragment_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.callback']/class[@name='AbstractSupportFragmentCallback']/method[@name='setSupportFragment' and count(parameter)=1 and parameter[1][@type='android.support.v4.app.Fragment']]"
		[Register ("setSupportFragment", "(Landroid/support/v4/app/Fragment;)V", "GetSetSupportFragment_Landroid_support_v4_app_Fragment_Handler")]
		public virtual unsafe void SetSupportFragment (global::Android.Support.V4.App.Fragment p0)
		{
			if (id_setSupportFragment_Landroid_support_v4_app_Fragment_ == IntPtr.Zero)
				id_setSupportFragment_Landroid_support_v4_app_Fragment_ = JNIEnv.GetMethodID (class_ref, "setSupportFragment", "(Landroid/support/v4/app/Fragment;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSupportFragment_Landroid_support_v4_app_Fragment_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSupportFragment", "(Landroid/support/v4/app/Fragment;)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/callback/AbstractSupportFragmentCallback", DoNotGenerateAcw=true)]
	internal partial class AbstractSupportFragmentCallbackInvoker : AbstractSupportFragmentCallback {

		public AbstractSupportFragmentCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractSupportFragmentCallbackInvoker); }
		}

	}

}
