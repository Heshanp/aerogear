using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Pipe.Loader {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.loader']/class[@name='SaveLoader']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/loader/SaveLoader", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class SaveLoader : global::Org.Jboss.Aerogear.Android.Pipe.Loader.AbstractPipeLoader {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/pipe/loader/SaveLoader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SaveLoader); }
		}

		protected SaveLoader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_loadInBackground;
#pragma warning disable 0169
		static Delegate GetLoadInBackgroundHandler ()
		{
			if (cb_loadInBackground == null)
				cb_loadInBackground = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_LoadInBackground);
			return cb_loadInBackground;
		}

		static IntPtr n_LoadInBackground (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Loader.SaveLoader __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Loader.SaveLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LoadInBackground ());
		}
#pragma warning restore 0169

		static IntPtr id_loadInBackground;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.loader']/class[@name='SaveLoader']/method[@name='loadInBackground' and count(parameter)=0]"
		[Register ("loadInBackground", "()Ljava/lang/Object;", "GetLoadInBackgroundHandler")]
		public override unsafe global::Java.Lang.Object LoadInBackground ()
		{
			if (id_loadInBackground == IntPtr.Zero)
				id_loadInBackground = JNIEnv.GetMethodID (class_ref, "loadInBackground", "()Ljava/lang/Object;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_loadInBackground), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadInBackground", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
