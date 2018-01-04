using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Pipe.Rest.Gson {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest.gson']/class[@name='GsonRequestBuilder']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/rest/gson/GsonRequestBuilder", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class GsonRequestBuilder : global::Java.Lang.Object, global::Org.Jboss.Aerogear.Android.Pipe.IRequestBuilder {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/pipe/rest/gson/GsonRequestBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GsonRequestBuilder); }
		}

		protected GsonRequestBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest.gson']/class[@name='GsonRequestBuilder']/constructor[@name='GsonRequestBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GsonRequestBuilder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GsonRequestBuilder)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest.gson']/class[@name='GsonRequestBuilder']/constructor[@name='GsonRequestBuilder' and count(parameter)=1 and parameter[1][@type='com.google.gson.Gson']]"
		[Register (".ctor", "(Lcom/google/gson/Gson;)V", "")]
		public unsafe GsonRequestBuilder (global::GoogleGson.Gson p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (GsonRequestBuilder)) {
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

		static Delegate cb_getContentType;
#pragma warning disable 0169
		static Delegate GetGetContentTypeHandler ()
		{
			if (cb_getContentType == null)
				cb_getContentType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentType);
			return cb_getContentType;
		}

		static IntPtr n_GetContentType (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Rest.Gson.GsonRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Rest.Gson.GsonRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentType);
		}
#pragma warning restore 0169

		static IntPtr id_getContentType;
		public virtual unsafe string ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest.gson']/class[@name='GsonRequestBuilder']/method[@name='getContentType' and count(parameter)=0]"
			[Register ("getContentType", "()Ljava/lang/String;", "GetGetContentTypeHandler")]
			get {
				if (id_getContentType == IntPtr.Zero)
					id_getContentType = JNIEnv.GetMethodID (class_ref, "getContentType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContentType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Org.Jboss.Aerogear.Android.Pipe.Rest.Gson.GsonRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Rest.Gson.GsonRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Jboss.Aerogear.Android.Pipe.Rest.Gson.GsonRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Rest.Gson.GsonRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jboss.Aerogear.Android.Pipe.MarshallingConfig p0 = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.MarshallingConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MarshallingConfig = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMarshallingConfig;
		static IntPtr id_setMarshallingConfig_Lorg_jboss_aerogear_android_pipe_MarshallingConfig_;
		public virtual unsafe global::Org.Jboss.Aerogear.Android.Pipe.MarshallingConfig MarshallingConfig {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest.gson']/class[@name='GsonRequestBuilder']/method[@name='getMarshallingConfig' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest.gson']/class[@name='GsonRequestBuilder']/method[@name='setMarshallingConfig' and count(parameter)=1 and parameter[1][@type='org.jboss.aerogear.android.pipe.MarshallingConfig']]"
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

		static Delegate cb_getBody_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetBody_Ljava_lang_Object_Handler ()
		{
			if (cb_getBody_Ljava_lang_Object_ == null)
				cb_getBody_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBody_Ljava_lang_Object_);
			return cb_getBody_Ljava_lang_Object_;
		}

		static IntPtr n_GetBody_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Rest.Gson.GsonRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Rest.Gson.GsonRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetBody (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getBody_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest.gson']/class[@name='GsonRequestBuilder']/method[@name='getBody' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("getBody", "(Ljava/lang/Object;)[B", "GetGetBody_Ljava_lang_Object_Handler")]
		public virtual unsafe byte[] GetBody (global::Java.Lang.Object p0)
		{
			if (id_getBody_Ljava_lang_Object_ == IntPtr.Zero)
				id_getBody_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getBody", "(Ljava/lang/Object;)[B");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				byte[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBody_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBody", "(Ljava/lang/Object;)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
