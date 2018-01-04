using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Unifiedpush.Metrics {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.metrics']/interface[@name='MetricsSender']"
	[Register ("org/jboss/aerogear/android/unifiedpush/metrics/MetricsSender", "", "Org.Jboss.Aerogear.Android.Unifiedpush.Metrics.IMetricsSenderInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends org.jboss.aerogear.android.unifiedpush.metrics.MetricsMessage"})]
	public partial interface IMetricsSender : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.metrics']/interface[@name='MetricsSender']/method[@name='sendMetrics' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='org.jboss.aerogear.android.core.Callback&lt;T&gt;']]"
		[Register ("sendMetrics", "(Lorg/jboss/aerogear/android/unifiedpush/metrics/MetricsMessage;Lorg/jboss/aerogear/android/core/Callback;)V", "GetSendMetrics_Lorg_jboss_aerogear_android_unifiedpush_metrics_MetricsMessage_Lorg_jboss_aerogear_android_core_Callback_Handler:Org.Jboss.Aerogear.Android.Unifiedpush.Metrics.IMetricsSenderInvoker, ClassLibrary6")]
		void SendMetrics (global::Java.Lang.Object p0, global::Org.Jboss.Aerogear.Android.Core.ICallback p1);

	}

	[global::Android.Runtime.Register ("org/jboss/aerogear/android/unifiedpush/metrics/MetricsSender", DoNotGenerateAcw=true)]
	internal class IMetricsSenderInvoker : global::Java.Lang.Object, IMetricsSender {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/jboss/aerogear/android/unifiedpush/metrics/MetricsSender");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMetricsSenderInvoker); }
		}

		IntPtr class_ref;

		public static IMetricsSender GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMetricsSender> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.jboss.aerogear.android.unifiedpush.metrics.MetricsSender"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMetricsSenderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_sendMetrics_Lorg_jboss_aerogear_android_unifiedpush_metrics_MetricsMessage_Lorg_jboss_aerogear_android_core_Callback_;
#pragma warning disable 0169
		static Delegate GetSendMetrics_Lorg_jboss_aerogear_android_unifiedpush_metrics_MetricsMessage_Lorg_jboss_aerogear_android_core_Callback_Handler ()
		{
			if (cb_sendMetrics_Lorg_jboss_aerogear_android_unifiedpush_metrics_MetricsMessage_Lorg_jboss_aerogear_android_core_Callback_ == null)
				cb_sendMetrics_Lorg_jboss_aerogear_android_unifiedpush_metrics_MetricsMessage_Lorg_jboss_aerogear_android_core_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendMetrics_Lorg_jboss_aerogear_android_unifiedpush_metrics_MetricsMessage_Lorg_jboss_aerogear_android_core_Callback_);
			return cb_sendMetrics_Lorg_jboss_aerogear_android_unifiedpush_metrics_MetricsMessage_Lorg_jboss_aerogear_android_core_Callback_;
		}

		static void n_SendMetrics_Lorg_jboss_aerogear_android_unifiedpush_metrics_MetricsMessage_Lorg_jboss_aerogear_android_core_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Jboss.Aerogear.Android.Unifiedpush.Metrics.IMetricsSender __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Unifiedpush.Metrics.IMetricsSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Jboss.Aerogear.Android.Core.ICallback p1 = (global::Org.Jboss.Aerogear.Android.Core.ICallback)global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Core.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendMetrics (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_sendMetrics_Lorg_jboss_aerogear_android_unifiedpush_metrics_MetricsMessage_Lorg_jboss_aerogear_android_core_Callback_;
		public unsafe void SendMetrics (global::Java.Lang.Object p0, global::Org.Jboss.Aerogear.Android.Core.ICallback p1)
		{
			if (id_sendMetrics_Lorg_jboss_aerogear_android_unifiedpush_metrics_MetricsMessage_Lorg_jboss_aerogear_android_core_Callback_ == IntPtr.Zero)
				id_sendMetrics_Lorg_jboss_aerogear_android_unifiedpush_metrics_MetricsMessage_Lorg_jboss_aerogear_android_core_Callback_ = JNIEnv.GetMethodID (class_ref, "sendMetrics", "(Lorg/jboss/aerogear/android/unifiedpush/metrics/MetricsMessage;Lorg/jboss/aerogear/android/core/Callback;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMetrics_Lorg_jboss_aerogear_android_unifiedpush_metrics_MetricsMessage_Lorg_jboss_aerogear_android_core_Callback_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
