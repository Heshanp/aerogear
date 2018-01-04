using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Pipe.Loader {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.loader']/class[@name='AbstractPipeLoader']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/loader/AbstractPipeLoader", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class AbstractPipeLoader : global::Android.Content.AsyncTaskLoader {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/pipe/loader/AbstractPipeLoader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractPipeLoader); }
		}

		protected AbstractPipeLoader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getException;
#pragma warning disable 0169
		static Delegate GetGetExceptionHandler ()
		{
			if (cb_getException == null)
				cb_getException = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetException);
			return cb_getException;
		}

		static IntPtr n_GetException (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Loader.AbstractPipeLoader __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Loader.AbstractPipeLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Exception);
		}
#pragma warning restore 0169

		static IntPtr id_getException;
		public virtual unsafe global::Java.Lang.Exception Exception {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.loader']/class[@name='AbstractPipeLoader']/method[@name='getException' and count(parameter)=0]"
			[Register ("getException", "()Ljava/lang/Exception;", "GetGetExceptionHandler")]
			get {
				if (id_getException == IntPtr.Zero)
					id_getException = JNIEnv.GetMethodID (class_ref, "getException", "()Ljava/lang/Exception;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getException), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getException", "()Ljava/lang/Exception;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_hasException;
#pragma warning disable 0169
		static Delegate GetHasExceptionHandler ()
		{
			if (cb_hasException == null)
				cb_hasException = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasException);
			return cb_hasException;
		}

		static bool n_HasException (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Loader.AbstractPipeLoader __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Loader.AbstractPipeLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasException;
		}
#pragma warning restore 0169

		static IntPtr id_hasException;
		public virtual unsafe bool HasException {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.loader']/class[@name='AbstractPipeLoader']/method[@name='hasException' and count(parameter)=0]"
			[Register ("hasException", "()Z", "GetHasExceptionHandler")]
			get {
				if (id_hasException == IntPtr.Zero)
					id_hasException = JNIEnv.GetMethodID (class_ref, "hasException", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasException);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasException", "()Z"));
				} finally {
				}
			}
		}

	}

	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/loader/AbstractPipeLoader", DoNotGenerateAcw=true)]
	internal partial class AbstractPipeLoaderInvoker : AbstractPipeLoader {

		public AbstractPipeLoaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractPipeLoaderInvoker); }
		}

		static IntPtr id_loadInBackground;
		[Register ("loadInBackground", "()Ljava/lang/Object;", "GetLoadInBackgroundHandler")]
		public override unsafe global::Java.Lang.Object LoadInBackground ()
		{
			if (id_loadInBackground == IntPtr.Zero)
				id_loadInBackground = JNIEnv.GetMethodID (class_ref, "loadInBackground", "()Ljava/lang/Object;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_loadInBackground), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
