using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Unifiedpush.Fcm {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.fcm']/class[@name='AeroGearFCMPushRegistrar']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/unifiedpush/fcm/AeroGearFCMPushRegistrar", DoNotGenerateAcw=true)]
	public partial class AeroGearFCMPushRegistrar : global::Java.Lang.Object, global::Org.Jboss.Aerogear.Android.Unifiedpush.IPushRegistrar, global::Org.Jboss.Aerogear.Android.Unifiedpush.Metrics.IMetricsSender {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/unifiedpush/fcm/AeroGearFCMPushRegistrar", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AeroGearFCMPushRegistrar); }
		}

		protected AeroGearFCMPushRegistrar (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jboss_aerogear_android_unifiedpush_fcm_UnifiedPushConfig_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.fcm']/class[@name='AeroGearFCMPushRegistrar']/constructor[@name='AeroGearFCMPushRegistrar' and count(parameter)=1 and parameter[1][@type='org.jboss.aerogear.android.unifiedpush.fcm.UnifiedPushConfig']]"
		[Register (".ctor", "(Lorg/jboss/aerogear/android/unifiedpush/fcm/UnifiedPushConfig;)V", "")]
		public unsafe AeroGearFCMPushRegistrar (global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.UnifiedPushConfig config)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (config);
				if (((object) this).GetType () != typeof (AeroGearFCMPushRegistrar)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/jboss/aerogear/android/unifiedpush/fcm/UnifiedPushConfig;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jboss/aerogear/android/unifiedpush/fcm/UnifiedPushConfig;)V", __args);
					return;
				}

				if (id_ctor_Lorg_jboss_aerogear_android_unifiedpush_fcm_UnifiedPushConfig_ == IntPtr.Zero)
					id_ctor_Lorg_jboss_aerogear_android_unifiedpush_fcm_UnifiedPushConfig_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jboss/aerogear/android/unifiedpush/fcm/UnifiedPushConfig;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jboss_aerogear_android_unifiedpush_fcm_UnifiedPushConfig_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jboss_aerogear_android_unifiedpush_fcm_UnifiedPushConfig_, __args);
			} finally {
			}
		}

		static Delegate cb_register_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_;
#pragma warning disable 0169
		static Delegate GetRegister_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_Handler ()
		{
			if (cb_register_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_ == null)
				cb_register_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Register_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_);
			return cb_register_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_;
		}

		static void n_Register_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native__callback)
		{
			global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.AeroGearFCMPushRegistrar __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.AeroGearFCMPushRegistrar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			global::Org.Jboss.Aerogear.Android.Core.ICallback @callback = (global::Org.Jboss.Aerogear.Android.Core.ICallback)global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Core.ICallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.Register (context, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_register_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.fcm']/class[@name='AeroGearFCMPushRegistrar']/method[@name='register' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.jboss.aerogear.android.core.Callback&lt;java.lang.Void&gt;']]"
		[Register ("register", "(Landroid/content/Context;Lorg/jboss/aerogear/android/core/Callback;)V", "GetRegister_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_Handler")]
		public virtual unsafe void Register (global::Android.Content.Context context, global::Org.Jboss.Aerogear.Android.Core.ICallback @callback)
		{
			if (id_register_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_ == IntPtr.Zero)
				id_register_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_ = JNIEnv.GetMethodID (class_ref, "register", "(Landroid/content/Context;Lorg/jboss/aerogear/android/core/Callback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_register_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "register", "(Landroid/content/Context;Lorg/jboss/aerogear/android/core/Callback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_sendMetrics_Lorg_jboss_aerogear_android_unifiedpush_metrics_UnifiedPushMetricsMessage_Lorg_jboss_aerogear_android_core_Callback_;
#pragma warning disable 0169
		static Delegate GetSendMetrics_Lorg_jboss_aerogear_android_unifiedpush_metrics_UnifiedPushMetricsMessage_Lorg_jboss_aerogear_android_core_Callback_Handler ()
		{
			if (cb_sendMetrics_Lorg_jboss_aerogear_android_unifiedpush_metrics_UnifiedPushMetricsMessage_Lorg_jboss_aerogear_android_core_Callback_ == null)
				cb_sendMetrics_Lorg_jboss_aerogear_android_unifiedpush_metrics_UnifiedPushMetricsMessage_Lorg_jboss_aerogear_android_core_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendMetrics_Lorg_jboss_aerogear_android_unifiedpush_metrics_UnifiedPushMetricsMessage_Lorg_jboss_aerogear_android_core_Callback_);
			return cb_sendMetrics_Lorg_jboss_aerogear_android_unifiedpush_metrics_UnifiedPushMetricsMessage_Lorg_jboss_aerogear_android_core_Callback_;
		}

		static void n_SendMetrics_Lorg_jboss_aerogear_android_unifiedpush_metrics_UnifiedPushMetricsMessage_Lorg_jboss_aerogear_android_core_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_metricsMessage, IntPtr native__callback)
		{
			global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.AeroGearFCMPushRegistrar __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.AeroGearFCMPushRegistrar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jboss.Aerogear.Android.Unifiedpush.Metrics.UnifiedPushMetricsMessage metricsMessage = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Unifiedpush.Metrics.UnifiedPushMetricsMessage> (native_metricsMessage, JniHandleOwnership.DoNotTransfer);
			global::Org.Jboss.Aerogear.Android.Core.ICallback @callback = (global::Org.Jboss.Aerogear.Android.Core.ICallback)global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Core.ICallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SendMetrics (metricsMessage, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_sendMetrics_Lorg_jboss_aerogear_android_unifiedpush_metrics_UnifiedPushMetricsMessage_Lorg_jboss_aerogear_android_core_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.fcm']/class[@name='AeroGearFCMPushRegistrar']/method[@name='sendMetrics' and count(parameter)=2 and parameter[1][@type='org.jboss.aerogear.android.unifiedpush.metrics.UnifiedPushMetricsMessage'] and parameter[2][@type='org.jboss.aerogear.android.core.Callback&lt;org.jboss.aerogear.android.unifiedpush.metrics.UnifiedPushMetricsMessage&gt;']]"
		[Register ("sendMetrics", "(Lorg/jboss/aerogear/android/unifiedpush/metrics/UnifiedPushMetricsMessage;Lorg/jboss/aerogear/android/core/Callback;)V", "GetSendMetrics_Lorg_jboss_aerogear_android_unifiedpush_metrics_UnifiedPushMetricsMessage_Lorg_jboss_aerogear_android_core_Callback_Handler")]
		public virtual unsafe void SendMetrics (global::Org.Jboss.Aerogear.Android.Unifiedpush.Metrics.UnifiedPushMetricsMessage metricsMessage, global::Org.Jboss.Aerogear.Android.Core.ICallback @callback)
		{
			if (id_sendMetrics_Lorg_jboss_aerogear_android_unifiedpush_metrics_UnifiedPushMetricsMessage_Lorg_jboss_aerogear_android_core_Callback_ == IntPtr.Zero)
				id_sendMetrics_Lorg_jboss_aerogear_android_unifiedpush_metrics_UnifiedPushMetricsMessage_Lorg_jboss_aerogear_android_core_Callback_ = JNIEnv.GetMethodID (class_ref, "sendMetrics", "(Lorg/jboss/aerogear/android/unifiedpush/metrics/UnifiedPushMetricsMessage;Lorg/jboss/aerogear/android/core/Callback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (metricsMessage);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMetrics_Lorg_jboss_aerogear_android_unifiedpush_metrics_UnifiedPushMetricsMessage_Lorg_jboss_aerogear_android_core_Callback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendMetrics", "(Lorg/jboss/aerogear/android/unifiedpush/metrics/UnifiedPushMetricsMessage;Lorg/jboss/aerogear/android/core/Callback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setPasswordAuthentication_Ljava_lang_String_Ljava_lang_String_Lorg_jboss_aerogear_android_pipe_http_HttpProvider_;
#pragma warning disable 0169
		static Delegate GetSetPasswordAuthentication_Ljava_lang_String_Ljava_lang_String_Lorg_jboss_aerogear_android_pipe_http_HttpProvider_Handler ()
		{
			if (cb_setPasswordAuthentication_Ljava_lang_String_Ljava_lang_String_Lorg_jboss_aerogear_android_pipe_http_HttpProvider_ == null)
				cb_setPasswordAuthentication_Ljava_lang_String_Ljava_lang_String_Lorg_jboss_aerogear_android_pipe_http_HttpProvider_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPasswordAuthentication_Ljava_lang_String_Ljava_lang_String_Lorg_jboss_aerogear_android_pipe_http_HttpProvider_);
			return cb_setPasswordAuthentication_Ljava_lang_String_Ljava_lang_String_Lorg_jboss_aerogear_android_pipe_http_HttpProvider_;
		}

		static void n_SetPasswordAuthentication_Ljava_lang_String_Ljava_lang_String_Lorg_jboss_aerogear_android_pipe_http_HttpProvider_ (IntPtr jnienv, IntPtr native__this, IntPtr native_username, IntPtr native_password, IntPtr native_provider)
		{
			global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.AeroGearFCMPushRegistrar __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.AeroGearFCMPushRegistrar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string username = JNIEnv.GetString (native_username, JniHandleOwnership.DoNotTransfer);
			string password = JNIEnv.GetString (native_password, JniHandleOwnership.DoNotTransfer);
			global::Org.Jboss.Aerogear.Android.Pipe.Http.IHttpProvider provider = (global::Org.Jboss.Aerogear.Android.Pipe.Http.IHttpProvider)global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Http.IHttpProvider> (native_provider, JniHandleOwnership.DoNotTransfer);
			__this.SetPasswordAuthentication (username, password, provider);
		}
#pragma warning restore 0169

		static IntPtr id_setPasswordAuthentication_Ljava_lang_String_Ljava_lang_String_Lorg_jboss_aerogear_android_pipe_http_HttpProvider_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.fcm']/class[@name='AeroGearFCMPushRegistrar']/method[@name='setPasswordAuthentication' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.jboss.aerogear.android.pipe.http.HttpProvider']]"
		[Register ("setPasswordAuthentication", "(Ljava/lang/String;Ljava/lang/String;Lorg/jboss/aerogear/android/pipe/http/HttpProvider;)V", "GetSetPasswordAuthentication_Ljava_lang_String_Ljava_lang_String_Lorg_jboss_aerogear_android_pipe_http_HttpProvider_Handler")]
		public virtual unsafe void SetPasswordAuthentication (string username, string password, global::Org.Jboss.Aerogear.Android.Pipe.Http.IHttpProvider provider)
		{
			if (id_setPasswordAuthentication_Ljava_lang_String_Ljava_lang_String_Lorg_jboss_aerogear_android_pipe_http_HttpProvider_ == IntPtr.Zero)
				id_setPasswordAuthentication_Ljava_lang_String_Ljava_lang_String_Lorg_jboss_aerogear_android_pipe_http_HttpProvider_ = JNIEnv.GetMethodID (class_ref, "setPasswordAuthentication", "(Ljava/lang/String;Ljava/lang/String;Lorg/jboss/aerogear/android/pipe/http/HttpProvider;)V");
			IntPtr native_username = JNIEnv.NewString (username);
			IntPtr native_password = JNIEnv.NewString (password);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_username);
				__args [1] = new JValue (native_password);
				__args [2] = new JValue (provider);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPasswordAuthentication_Ljava_lang_String_Ljava_lang_String_Lorg_jboss_aerogear_android_pipe_http_HttpProvider_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPasswordAuthentication", "(Ljava/lang/String;Ljava/lang/String;Lorg/jboss/aerogear/android/pipe/http/HttpProvider;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_username);
				JNIEnv.DeleteLocalRef (native_password);
			}
		}

		static Delegate cb_unregister_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_;
#pragma warning disable 0169
		static Delegate GetUnregister_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_Handler ()
		{
			if (cb_unregister_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_ == null)
				cb_unregister_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Unregister_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_);
			return cb_unregister_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_;
		}

		static void n_Unregister_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native__callback)
		{
			global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.AeroGearFCMPushRegistrar __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.AeroGearFCMPushRegistrar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			global::Org.Jboss.Aerogear.Android.Core.ICallback @callback = (global::Org.Jboss.Aerogear.Android.Core.ICallback)global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Core.ICallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.Unregister (context, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_unregister_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.fcm']/class[@name='AeroGearFCMPushRegistrar']/method[@name='unregister' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.jboss.aerogear.android.core.Callback&lt;java.lang.Void&gt;']]"
		[Register ("unregister", "(Landroid/content/Context;Lorg/jboss/aerogear/android/core/Callback;)V", "GetUnregister_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_Handler")]
		public virtual unsafe void Unregister (global::Android.Content.Context context, global::Org.Jboss.Aerogear.Android.Core.ICallback @callback)
		{
			if (id_unregister_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_ == IntPtr.Zero)
				id_unregister_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_ = JNIEnv.GetMethodID (class_ref, "unregister", "(Landroid/content/Context;Lorg/jboss/aerogear/android/core/Callback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregister_Landroid_content_Context_Lorg_jboss_aerogear_android_core_Callback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregister", "(Landroid/content/Context;Lorg/jboss/aerogear/android/core/Callback;)V"), __args);
			} finally {
			}
		}

		// This method is explicitly implemented as a member of an instantiated Org.Jboss.Aerogear.Android.Unifiedpush.Metrics.IMetricsSender
		void global::Org.Jboss.Aerogear.Android.Unifiedpush.Metrics.IMetricsSender.SendMetrics (global::Java.Lang.Object p0, global::Org.Jboss.Aerogear.Android.Core.ICallback p1)
		{
			SendMetrics (global::Java.Interop.JavaObjectExtensions.JavaCast<global::Org.Jboss.Aerogear.Android.Unifiedpush.Metrics.UnifiedPushMetricsMessage>(p0), global::Java.Interop.JavaObjectExtensions.JavaCast<global::Org.Jboss.Aerogear.Android.Core.ICallback>(p1));
		}

	}
}
