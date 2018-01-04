using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Unifiedpush {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush']/interface[@name='MessageHandler']"
	[Register ("org/jboss/aerogear/android/unifiedpush/MessageHandler", "", "Org.Jboss.Aerogear.Android.Unifiedpush.IMessageHandlerInvoker")]
	public partial interface IMessageHandler : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush']/interface[@name='MessageHandler']/method[@name='onMessage' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("onMessage", "(Landroid/content/Context;Landroid/os/Bundle;)V", "GetOnMessage_Landroid_content_Context_Landroid_os_Bundle_Handler:Org.Jboss.Aerogear.Android.Unifiedpush.IMessageHandlerInvoker, ClassLibrary6")]
		void OnMessage (global::Android.Content.Context p0, global::Android.OS.Bundle p1);

	}

	[global::Android.Runtime.Register ("org/jboss/aerogear/android/unifiedpush/MessageHandler", DoNotGenerateAcw=true)]
	internal class IMessageHandlerInvoker : global::Java.Lang.Object, IMessageHandler {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/jboss/aerogear/android/unifiedpush/MessageHandler");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMessageHandlerInvoker); }
		}

		IntPtr class_ref;

		public static IMessageHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMessageHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.jboss.aerogear.android.unifiedpush.MessageHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMessageHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onMessage_Landroid_content_Context_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnMessage_Landroid_content_Context_Landroid_os_Bundle_Handler ()
		{
			if (cb_onMessage_Landroid_content_Context_Landroid_os_Bundle_ == null)
				cb_onMessage_Landroid_content_Context_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnMessage_Landroid_content_Context_Landroid_os_Bundle_);
			return cb_onMessage_Landroid_content_Context_Landroid_os_Bundle_;
		}

		static void n_OnMessage_Landroid_content_Context_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Jboss.Aerogear.Android.Unifiedpush.IMessageHandler __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Unifiedpush.IMessageHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnMessage (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onMessage_Landroid_content_Context_Landroid_os_Bundle_;
		public unsafe void OnMessage (global::Android.Content.Context p0, global::Android.OS.Bundle p1)
		{
			if (id_onMessage_Landroid_content_Context_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onMessage_Landroid_content_Context_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onMessage", "(Landroid/content/Context;Landroid/os/Bundle;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMessage_Landroid_content_Context_Landroid_os_Bundle_, __args);
		}

	}

}
