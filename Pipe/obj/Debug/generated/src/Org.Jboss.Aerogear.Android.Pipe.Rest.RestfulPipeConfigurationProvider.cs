using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Pipe.Rest {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest']/class[@name='RestfulPipeConfigurationProvider']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/rest/RestfulPipeConfigurationProvider", DoNotGenerateAcw=true)]
	public partial class RestfulPipeConfigurationProvider : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/pipe/rest/RestfulPipeConfigurationProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RestfulPipeConfigurationProvider); }
		}

		protected RestfulPipeConfigurationProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest']/class[@name='RestfulPipeConfigurationProvider']/constructor[@name='RestfulPipeConfigurationProvider' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RestfulPipeConfigurationProvider ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (RestfulPipeConfigurationProvider)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_newConfiguration;
#pragma warning disable 0169
		static Delegate GetNewConfigurationHandler ()
		{
			if (cb_newConfiguration == null)
				cb_newConfiguration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NewConfiguration);
			return cb_newConfiguration;
		}

		static IntPtr n_NewConfiguration (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfigurationProvider __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfigurationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewConfiguration ());
		}
#pragma warning restore 0169

		static IntPtr id_newConfiguration;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest']/class[@name='RestfulPipeConfigurationProvider']/method[@name='newConfiguration' and count(parameter)=0]"
		[Register ("newConfiguration", "()Lorg/jboss/aerogear/android/pipe/rest/RestfulPipeConfiguration;", "GetNewConfigurationHandler")]
		public virtual unsafe global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration NewConfiguration ()
		{
			if (id_newConfiguration == IntPtr.Zero)
				id_newConfiguration = JNIEnv.GetMethodID (class_ref, "newConfiguration", "()Lorg/jboss/aerogear/android/pipe/rest/RestfulPipeConfiguration;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_newConfiguration), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newConfiguration", "()Lorg/jboss/aerogear/android/pipe/rest/RestfulPipeConfiguration;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
