using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Pipe.Rest.Gson {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest.gson']/class[@name='GsonResponseParser']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/rest/gson/GsonResponseParser", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class GsonResponseParser : global::Java.Lang.Object, global::Org.Jboss.Aerogear.Android.Pipe.IResponseParser {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/pipe/rest/gson/GsonResponseParser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GsonResponseParser); }
		}

		protected GsonResponseParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest.gson']/class[@name='GsonResponseParser']/constructor[@name='GsonResponseParser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GsonResponseParser ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GsonResponseParser)) {
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

		static IntPtr id_ctor_Lcom_google_gson_Gson_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest.gson']/class[@name='GsonResponseParser']/constructor[@name='GsonResponseParser' and count(parameter)=1 and parameter[1][@type='com.google.gson.Gson']]"
		[Register (".ctor", "(Lcom/google/gson/Gson;)V", "")]
		public unsafe GsonResponseParser (global::GoogleGson.Gson p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (GsonResponseParser)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/google/gson/Gson;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/google/gson/Gson;)V", __args);
					return;
				}

				if (id_ctor_Lcom_google_gson_Gson_ == IntPtr.Zero)
					id_ctor_Lcom_google_gson_Gson_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/gson/Gson;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_google_gson_Gson_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_google_gson_Gson_, __args);
			} finally {
			}
		}

		static Delegate cb_getMarshallingConfig;
#pragma warning disable 0169
		static Delegate GetGetMarshallingConfigHandler ()
		{
			if (cb_getMarshallingConfig == null)
				cb_getMarshallingConfig = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMarshallingConfig);
			return cb_getMarshallingConfig;
		}

		static IntPtr n_GetMarshallingConfig (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Rest.Gson.GsonResponseParser __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Rest.Gson.GsonResponseParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MarshallingConfig);
		}
#pragma warning restore 0169

		static Delegate cb_setMarshallingConfig_Lorg_jboss_aerogear_android_pipe_MarshallingConfig_;
#pragma warning disable 0169
		static Delegate GetSetMarshallingConfig_Lorg_jboss_aerogear_android_pipe_MarshallingConfig_Handler ()
		{
			if (cb_setMarshallingConfig_Lorg_jboss_aerogear_android_pipe_MarshallingConfig_ == null)
				cb_setMarshallingConfig_Lorg_jboss_aerogear_android_pipe_MarshallingConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMarshallingConfig_Lorg_jboss_aerogear_android_pipe_MarshallingConfig_);
			return cb_setMarshallingConfig_Lorg_jboss_aerogear_android_pipe_MarshallingConfig_;
		}

		static void n_SetMarshallingConfig_Lorg_jboss_aerogear_android_pipe_MarshallingConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Rest.Gson.GsonResponseParser __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Rest.Gson.GsonResponseParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jboss.Aerogear.Android.Pipe.MarshallingConfig p0 = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.MarshallingConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MarshallingConfig = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMarshallingConfig;
		static IntPtr id_setMarshallingConfig_Lorg_jboss_aerogear_android_pipe_MarshallingConfig_;
		public virtual unsafe global::Org.Jboss.Aerogear.Android.Pipe.MarshallingConfig MarshallingConfig {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest.gson']/class[@name='GsonResponseParser']/method[@name='getMarshallingConfig' and count(parameter)=0]"
			[Register ("getMarshallingConfig", "()Lorg/jboss/aerogear/android/pipe/MarshallingConfig;", "GetGetMarshallingConfigHandler")]
			get {
				if (id_getMarshallingConfig == IntPtr.Zero)
					id_getMarshallingConfig = JNIEnv.GetMethodID (class_ref, "getMarshallingConfig", "()Lorg/jboss/aerogear/android/pipe/MarshallingConfig;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.MarshallingConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMarshallingConfig), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.MarshallingConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMarshallingConfig", "()Lorg/jboss/aerogear/android/pipe/MarshallingConfig;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest.gson']/class[@name='GsonResponseParser']/method[@name='setMarshallingConfig' and count(parameter)=1 and parameter[1][@type='org.jboss.aerogear.android.pipe.MarshallingConfig']]"
			[Register ("setMarshallingConfig", "(Lorg/jboss/aerogear/android/pipe/MarshallingConfig;)V", "GetSetMarshallingConfig_Lorg_jboss_aerogear_android_pipe_MarshallingConfig_Handler")]
			set {
				if (id_setMarshallingConfig_Lorg_jboss_aerogear_android_pipe_MarshallingConfig_ == IntPtr.Zero)
					id_setMarshallingConfig_Lorg_jboss_aerogear_android_pipe_MarshallingConfig_ = JNIEnv.GetMethodID (class_ref, "setMarshallingConfig", "(Lorg/jboss/aerogear/android/pipe/MarshallingConfig;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMarshallingConfig_Lorg_jboss_aerogear_android_pipe_MarshallingConfig_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMarshallingConfig", "(Lorg/jboss/aerogear/android/pipe/MarshallingConfig;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_handleResponse_Lorg_jboss_aerogear_android_pipe_http_HeaderAndBody_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetHandleResponse_Lorg_jboss_aerogear_android_pipe_http_HeaderAndBody_Ljava_lang_Class_Handler ()
		{
			if (cb_handleResponse_Lorg_jboss_aerogear_android_pipe_http_HeaderAndBody_Ljava_lang_Class_ == null)
				cb_handleResponse_Lorg_jboss_aerogear_android_pipe_http_HeaderAndBody_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_HandleResponse_Lorg_jboss_aerogear_android_pipe_http_HeaderAndBody_Ljava_lang_Class_);
			return cb_handleResponse_Lorg_jboss_aerogear_android_pipe_http_HeaderAndBody_Ljava_lang_Class_;
		}

		static IntPtr n_HandleResponse_Lorg_jboss_aerogear_android_pipe_http_HeaderAndBody_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Rest.Gson.GsonResponseParser __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Rest.Gson.GsonResponseParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody p0 = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList.ToLocalJniHandle (__this.HandleResponse (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_handleResponse_Lorg_jboss_aerogear_android_pipe_http_HeaderAndBody_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest.gson']/class[@name='GsonResponseParser']/method[@name='handleResponse' and count(parameter)=2 and parameter[1][@type='org.jboss.aerogear.android.pipe.http.HeaderAndBody'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("handleResponse", "(Lorg/jboss/aerogear/android/pipe/http/HeaderAndBody;Ljava/lang/Class;)Ljava/util/List;", "GetHandleResponse_Lorg_jboss_aerogear_android_pipe_http_HeaderAndBody_Ljava_lang_Class_Handler")]
		public virtual unsafe global::System.Collections.IList HandleResponse (global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody p0, global::Java.Lang.Class p1)
		{
			if (id_handleResponse_Lorg_jboss_aerogear_android_pipe_http_HeaderAndBody_Ljava_lang_Class_ == IntPtr.Zero)
				id_handleResponse_Lorg_jboss_aerogear_android_pipe_http_HeaderAndBody_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "handleResponse", "(Lorg/jboss/aerogear/android/pipe/http/HeaderAndBody;Ljava/lang/Class;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::System.Collections.IList __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_handleResponse_Lorg_jboss_aerogear_android_pipe_http_HeaderAndBody_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleResponse", "(Lorg/jboss/aerogear/android/pipe/http/HeaderAndBody;Ljava/lang/Class;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
