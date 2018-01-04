using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Unifiedpush {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush']/interface[@name='PushRegistrar']"
	[Register ("org/jboss/aerogear/android/unifiedpush/PushRegistrar", "", "Org.Jboss.Aerogear.Android.Unifiedpush.IPushRegistrarInvoker")]
	public partial interface IPushRegistrar : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush']/interface[@name='PushRegistrar']/method[@name='register' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.jboss.aerogear.android.core.Callback&lt;java.lang.Void&gt;']]"
		[Register ("register", "(Landroid/content/Context;Lorg/jboss/aerogear/android/core/Callback;)V", "GetRegister_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_Handler:Org.Jboss.Aerogear.Android.Unifiedpush.IPushRegistrarInvoker, ClassLibrary6")]
		void Register (global::Android.Content.Context p0, global::Org.Jboss.Aerogear.Android.Core.ICallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush']/interface[@name='PushRegistrar']/method[@name='unregister' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.jboss.aerogear.android.core.Callback&lt;java.lang.Void&gt;']]"
		[Register ("unregister", "(Landroid/content/Context;Lorg/jboss/aerogear/android/core/Callback;)V", "GetUnregister_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_Handler:Org.Jboss.Aerogear.Android.Unifiedpush.IPushRegistrarInvoker, ClassLibrary6")]
		void Unregister (global::Android.Content.Context p0, global::Org.Jboss.Aerogear.Android.Core.ICallback p1);

	}

	[global::Android.Runtime.Register ("org/jboss/aerogear/android/unifiedpush/PushRegistrar", DoNotGenerateAcw=true)]
	internal class IPushRegistrarInvoker : global::Java.Lang.Object, IPushRegistrar {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/jboss/aerogear/android/unifiedpush/PushRegistrar");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IPushRegistrarInvoker); }
		}

		IntPtr class_ref;

		public static IPushRegistrar GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPushRegistrar> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.jboss.aerogear.android.unifiedpush.PushRegistrar"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPushRegistrarInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_register_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_;
#pragma warning disable 0169
		static Delegate GetRegister_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_Handler ()
		{
			if (cb_register_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_ == null)
				cb_register_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Register_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_);
			return cb_register_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_;
		}

		static void n_Register_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Jboss.Aerogear.Android.Unifiedpush.IPushRegistrar __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Unifiedpush.IPushRegistrar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Jboss.Aerogear.Android.Core.ICallback p1 = (global::Org.Jboss.Aerogear.Android.Core.ICallback)global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Core.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Register (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_register_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_;
		public unsafe void Register (global::Android.Content.Context p0, global::Org.Jboss.Aerogear.Android.Core.ICallback p1)
		{
			if (id_register_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_ == IntPtr.Zero)
				id_register_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_ = JNIEnv.GetMethodID (class_ref, "register", "(Landroid/content/Context;Lorg/jboss/aerogear/android/core/Callback;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_register_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_, __args);
		}

		static Delegate cb_unregister_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_;
#pragma warning disable 0169
		static Delegate GetUnregister_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_Handler ()
		{
			if (cb_unregister_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_ == null)
				cb_unregister_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Unregister_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_);
			return cb_unregister_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_;
		}

		static void n_Unregister_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Jboss.Aerogear.Android.Unifiedpush.IPushRegistrar __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Unifiedpush.IPushRegistrar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Jboss.Aerogear.Android.Core.ICallback p1 = (global::Org.Jboss.Aerogear.Android.Core.ICallback)global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Core.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Unregister (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_unregister_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_;
		public unsafe void Unregister (global::Android.Content.Context p0, global::Org.Jboss.Aerogear.Android.Core.ICallback p1)
		{
			if (id_unregister_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_ == IntPtr.Zero)
				id_unregister_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_ = JNIEnv.GetMethodID (class_ref, "unregister", "(Landroid/content/Context;Lorg/jboss/aerogear/android/core/Callback;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregister_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_, __args);
		}

	}

}
