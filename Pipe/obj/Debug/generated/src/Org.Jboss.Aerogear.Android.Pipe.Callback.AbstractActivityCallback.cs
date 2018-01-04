using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Pipe.Callback {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.callback']/class[@name='AbstractActivityCallback']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/callback/AbstractActivityCallback", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class AbstractActivityCallback : global::Org.Jboss.Aerogear.Android.Pipe.Callback.AbstractCallback {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/pipe/callback/AbstractActivityCallback", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractActivityCallback); }
		}

		protected AbstractActivityCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayLjava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.callback']/class[@name='AbstractActivityCallback']/constructor[@name='AbstractActivityCallback' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register (".ctor", "([Ljava/lang/Object;)V", "")]
		public unsafe AbstractActivityCallback (params global:: Java.Lang.Object[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (AbstractActivityCallback)) {
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

		static Delegate cb_getActivity;
#pragma warning disable 0169
		static Delegate GetGetActivityHandler ()
		{
			if (cb_getActivity == null)
				cb_getActivity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActivity);
			return cb_getActivity;
		}

		static IntPtr n_GetActivity (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Callback.AbstractActivityCallback __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Callback.AbstractActivityCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Activity);
		}
#pragma warning restore 0169

		static IntPtr id_getActivity;
		protected virtual unsafe global::Android.App.Activity Activity {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.callback']/class[@name='AbstractActivityCallback']/method[@name='getActivity' and count(parameter)=0]"
			[Register ("getActivity", "()Landroid/app/Activity;", "GetGetActivityHandler")]
			get {
				if (id_getActivity == IntPtr.Zero)
					id_getActivity = JNIEnv.GetMethodID (class_ref, "getActivity", "()Landroid/app/Activity;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getActivity), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getActivity", "()Landroid/app/Activity;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setActivity_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetSetActivity_Landroid_app_Activity_Handler ()
		{
			if (cb_setActivity_Landroid_app_Activity_ == null)
				cb_setActivity_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetActivity_Landroid_app_Activity_);
			return cb_setActivity_Landroid_app_Activity_;
		}

		static void n_SetActivity_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Callback.AbstractActivityCallback __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Callback.AbstractActivityCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetActivity (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setActivity_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.callback']/class[@name='AbstractActivityCallback']/method[@name='setActivity' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("setActivity", "(Landroid/app/Activity;)V", "GetSetActivity_Landroid_app_Activity_Handler")]
		public virtual unsafe void SetActivity (global::Android.App.Activity p0)
		{
			if (id_setActivity_Landroid_app_Activity_ == IntPtr.Zero)
				id_setActivity_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "setActivity", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setActivity_Landroid_app_Activity_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setActivity", "(Landroid/app/Activity;)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/callback/AbstractActivityCallback", DoNotGenerateAcw=true)]
	internal partial class AbstractActivityCallbackInvoker : AbstractActivityCallback {

		public AbstractActivityCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractActivityCallbackInvoker); }
		}

	}

}
