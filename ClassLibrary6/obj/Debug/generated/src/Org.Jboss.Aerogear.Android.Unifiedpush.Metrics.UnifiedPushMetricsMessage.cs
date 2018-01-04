using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Unifiedpush.Metrics {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.metrics']/class[@name='UnifiedPushMetricsMessage']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/unifiedpush/metrics/UnifiedPushMetricsMessage", DoNotGenerateAcw=true)]
	public partial class UnifiedPushMetricsMessage : global::Java.Lang.Object, global::Org.Jboss.Aerogear.Android.Unifiedpush.Metrics.IMetricsMessage {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/unifiedpush/metrics/UnifiedPushMetricsMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UnifiedPushMetricsMessage); }
		}

		protected UnifiedPushMetricsMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Bundle_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.metrics']/class[@name='UnifiedPushMetricsMessage']/constructor[@name='UnifiedPushMetricsMessage' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register (".ctor", "(Landroid/os/Bundle;)V", "")]
		public unsafe UnifiedPushMetricsMessage (global::Android.OS.Bundle bundle)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (bundle);
				if (((object) this).GetType () != typeof (UnifiedPushMetricsMessage)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/os/Bundle;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/os/Bundle;)V", __args);
					return;
				}

				if (id_ctor_Landroid_os_Bundle_ == IntPtr.Zero)
					id_ctor_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Bundle;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Bundle_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_os_Bundle_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.metrics']/class[@name='UnifiedPushMetricsMessage']/constructor[@name='UnifiedPushMetricsMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe UnifiedPushMetricsMessage (string messageId)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_messageId = JNIEnv.NewString (messageId);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_messageId);
				if (((object) this).GetType () != typeof (UnifiedPushMetricsMessage)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_messageId);
			}
		}

		static Delegate cb_getMessageId;
#pragma warning disable 0169
		static Delegate GetGetMessageIdHandler ()
		{
			if (cb_getMessageId == null)
				cb_getMessageId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageId);
			return cb_getMessageId;
		}

		static IntPtr n_GetMessageId (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Unifiedpush.Metrics.UnifiedPushMetricsMessage __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Unifiedpush.Metrics.UnifiedPushMetricsMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageId);
		}
#pragma warning restore 0169

		static IntPtr id_getMessageId;
		public virtual unsafe string MessageId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.metrics']/class[@name='UnifiedPushMetricsMessage']/method[@name='getMessageId' and count(parameter)=0]"
			[Register ("getMessageId", "()Ljava/lang/String;", "GetGetMessageIdHandler")]
			get {
				if (id_getMessageId == IntPtr.Zero)
					id_getMessageId = JNIEnv.GetMethodID (class_ref, "getMessageId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
