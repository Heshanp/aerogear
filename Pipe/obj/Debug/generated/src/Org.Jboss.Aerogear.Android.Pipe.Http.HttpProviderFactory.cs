using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Pipe.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.http']/class[@name='HttpProviderFactory']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/http/HttpProviderFactory", DoNotGenerateAcw=true)]
	public partial class HttpProviderFactory : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/pipe/http/HttpProviderFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpProviderFactory); }
		}

		protected HttpProviderFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.http']/class[@name='HttpProviderFactory']/constructor[@name='HttpProviderFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HttpProviderFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (HttpProviderFactory)) {
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

		static Delegate cb_get_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGet_arrayLjava_lang_Object_Handler ()
		{
			if (cb_get_arrayLjava_lang_Object_ == null)
				cb_get_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_arrayLjava_lang_Object_);
			return cb_get_arrayLjava_lang_Object_;
		}

		static IntPtr n_Get_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Http.HttpProviderFactory __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Http.HttpProviderFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.http']/class[@name='HttpProviderFactory']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("get", "([Ljava/lang/Object;)Lorg/jboss/aerogear/android/pipe/http/HttpProvider;", "GetGet_arrayLjava_lang_Object_Handler")]
		public virtual unsafe global::Org.Jboss.Aerogear.Android.Pipe.Http.IHttpProvider Get (params global:: Java.Lang.Object[] p0)
		{
			if (id_get_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_get_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "get", "([Ljava/lang/Object;)Lorg/jboss/aerogear/android/pipe/http/HttpProvider;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Org.Jboss.Aerogear.Android.Pipe.Http.IHttpProvider __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Http.IHttpProvider> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Http.IHttpProvider> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "([Ljava/lang/Object;)Lorg/jboss/aerogear/android/pipe/http/HttpProvider;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
