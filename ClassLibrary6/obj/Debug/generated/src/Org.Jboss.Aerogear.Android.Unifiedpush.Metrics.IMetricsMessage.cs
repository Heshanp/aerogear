using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Unifiedpush.Metrics {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.metrics']/interface[@name='MetricsMessage']"
	[Register ("org/jboss/aerogear/android/unifiedpush/metrics/MetricsMessage", "", "Org.Jboss.Aerogear.Android.Unifiedpush.Metrics.IMetricsMessageInvoker")]
	public partial interface IMetricsMessage : IJavaObject {

		string MessageId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.metrics']/interface[@name='MetricsMessage']/method[@name='getMessageId' and count(parameter)=0]"
			[Register ("getMessageId", "()Ljava/lang/String;", "GetGetMessageIdHandler:Org.Jboss.Aerogear.Android.Unifiedpush.Metrics.IMetricsMessageInvoker, ClassLibrary6")] get;
		}

	}

	[global::Android.Runtime.Register ("org/jboss/aerogear/android/unifiedpush/metrics/MetricsMessage", DoNotGenerateAcw=true)]
	internal class IMetricsMessageInvoker : global::Java.Lang.Object, IMetricsMessage {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/jboss/aerogear/android/unifiedpush/metrics/MetricsMessage");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMetricsMessageInvoker); }
		}

		IntPtr class_ref;

		public static IMetricsMessage GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMetricsMessage> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.jboss.aerogear.android.unifiedpush.metrics.MetricsMessage"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMetricsMessageInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Org.Jboss.Aerogear.Android.Unifiedpush.Metrics.IMetricsMessage __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Unifiedpush.Metrics.IMetricsMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageId);
		}
#pragma warning restore 0169

		IntPtr id_getMessageId;
		public unsafe string MessageId {
			get {
				if (id_getMessageId == IntPtr.Zero)
					id_getMessageId = JNIEnv.GetMethodID (class_ref, "getMessageId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageId), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
