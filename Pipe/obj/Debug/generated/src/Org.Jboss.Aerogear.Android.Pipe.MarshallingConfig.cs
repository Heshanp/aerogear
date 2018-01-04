using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Pipe {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.pipe']/class[@name='MarshallingConfig']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/MarshallingConfig", DoNotGenerateAcw=true)]
	public partial class MarshallingConfig : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/pipe/MarshallingConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MarshallingConfig); }
		}

		protected MarshallingConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.pipe']/class[@name='MarshallingConfig']/constructor[@name='MarshallingConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MarshallingConfig ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MarshallingConfig)) {
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

		static Delegate cb_getDataRoot;
#pragma warning disable 0169
		static Delegate GetGetDataRootHandler ()
		{
			if (cb_getDataRoot == null)
				cb_getDataRoot = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDataRoot);
			return cb_getDataRoot;
		}

		static IntPtr n_GetDataRoot (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.MarshallingConfig __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.MarshallingConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DataRoot);
		}
#pragma warning restore 0169

		static Delegate cb_setDataRoot_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDataRoot_Ljava_lang_String_Handler ()
		{
			if (cb_setDataRoot_Ljava_lang_String_ == null)
				cb_setDataRoot_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDataRoot_Ljava_lang_String_);
			return cb_setDataRoot_Ljava_lang_String_;
		}

		static void n_SetDataRoot_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.MarshallingConfig __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.MarshallingConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DataRoot = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDataRoot;
		static IntPtr id_setDataRoot_Ljava_lang_String_;
		public virtual unsafe string DataRoot {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe']/class[@name='MarshallingConfig']/method[@name='getDataRoot' and count(parameter)=0]"
			[Register ("getDataRoot", "()Ljava/lang/String;", "GetGetDataRootHandler")]
			get {
				if (id_getDataRoot == IntPtr.Zero)
					id_getDataRoot = JNIEnv.GetMethodID (class_ref, "getDataRoot", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDataRoot), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDataRoot", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe']/class[@name='MarshallingConfig']/method[@name='setDataRoot' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDataRoot", "(Ljava/lang/String;)V", "GetSetDataRoot_Ljava_lang_String_Handler")]
			set {
				if (id_setDataRoot_Ljava_lang_String_ == IntPtr.Zero)
					id_setDataRoot_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDataRoot", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDataRoot_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDataRoot", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getEncoding;
#pragma warning disable 0169
		static Delegate GetGetEncodingHandler ()
		{
			if (cb_getEncoding == null)
				cb_getEncoding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEncoding);
			return cb_getEncoding;
		}

		static IntPtr n_GetEncoding (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.MarshallingConfig __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.MarshallingConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Encoding);
		}
#pragma warning restore 0169

		static Delegate cb_setEncoding_Ljava_nio_charset_Charset_;
#pragma warning disable 0169
		static Delegate GetSetEncoding_Ljava_nio_charset_Charset_Handler ()
		{
			if (cb_setEncoding_Ljava_nio_charset_Charset_ == null)
				cb_setEncoding_Ljava_nio_charset_Charset_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEncoding_Ljava_nio_charset_Charset_);
			return cb_setEncoding_Ljava_nio_charset_Charset_;
		}

		static void n_SetEncoding_Ljava_nio_charset_Charset_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.MarshallingConfig __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.MarshallingConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.Charset.Charset p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Encoding = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEncoding;
		static IntPtr id_setEncoding_Ljava_nio_charset_Charset_;
		public virtual unsafe global::Java.Nio.Charset.Charset Encoding {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe']/class[@name='MarshallingConfig']/method[@name='getEncoding' and count(parameter)=0]"
			[Register ("getEncoding", "()Ljava/nio/charset/Charset;", "GetGetEncodingHandler")]
			get {
				if (id_getEncoding == IntPtr.Zero)
					id_getEncoding = JNIEnv.GetMethodID (class_ref, "getEncoding", "()Ljava/nio/charset/Charset;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEncoding), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEncoding", "()Ljava/nio/charset/Charset;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe']/class[@name='MarshallingConfig']/method[@name='setEncoding' and count(parameter)=1 and parameter[1][@type='java.nio.charset.Charset']]"
			[Register ("setEncoding", "(Ljava/nio/charset/Charset;)V", "GetSetEncoding_Ljava_nio_charset_Charset_Handler")]
			set {
				if (id_setEncoding_Ljava_nio_charset_Charset_ == IntPtr.Zero)
					id_setEncoding_Ljava_nio_charset_Charset_ = JNIEnv.GetMethodID (class_ref, "setEncoding", "(Ljava/nio/charset/Charset;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEncoding_Ljava_nio_charset_Charset_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEncoding", "(Ljava/nio/charset/Charset;)V"), __args);
				} finally {
				}
			}
		}

	}
}
