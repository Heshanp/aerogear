using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Pipe.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.http']/class[@name='HeaderAndBody']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/http/HeaderAndBody", DoNotGenerateAcw=true)]
	public partial class HeaderAndBody : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/pipe/http/HeaderAndBody", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HeaderAndBody); }
		}

		protected HeaderAndBody (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayBLjava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.http']/class[@name='HeaderAndBody']/constructor[@name='HeaderAndBody' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register (".ctor", "([BLjava/util/Map;)V", "")]
		public unsafe HeaderAndBody (byte[] p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (HeaderAndBody)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([BLjava/util/Map;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([BLjava/util/Map;)V", __args);
					return;
				}

				if (id_ctor_arrayBLjava_util_Map_ == IntPtr.Zero)
					id_ctor_arrayBLjava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "([BLjava/util/Map;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayBLjava_util_Map_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayBLjava_util_Map_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getBody;
#pragma warning disable 0169
		static Delegate GetGetBodyHandler ()
		{
			if (cb_getBody == null)
				cb_getBody = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBody);
			return cb_getBody;
		}

		static IntPtr n_GetBody (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetBody ());
		}
#pragma warning restore 0169

		static IntPtr id_getBody;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.http']/class[@name='HeaderAndBody']/method[@name='getBody' and count(parameter)=0]"
		[Register ("getBody", "()[B", "GetGetBodyHandler")]
		public virtual unsafe byte[] GetBody ()
		{
			if (id_getBody == IntPtr.Zero)
				id_getBody = JNIEnv.GetMethodID (class_ref, "getBody", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBody), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBody", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getHeader_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetHeader_Ljava_lang_String_Handler ()
		{
			if (cb_getHeader_Ljava_lang_String_ == null)
				cb_getHeader_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetHeader_Ljava_lang_String_);
			return cb_getHeader_Ljava_lang_String_;
		}

		static IntPtr n_GetHeader_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetHeader (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getHeader_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.http']/class[@name='HeaderAndBody']/method[@name='getHeader' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getHeader", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGetHeader_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Object GetHeader (string p0)
		{
			if (id_getHeader_Ljava_lang_String_ == IntPtr.Zero)
				id_getHeader_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getHeader", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHeader_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeader", "(Ljava/lang/String;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setHeader_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetHeader_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_setHeader_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_setHeader_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetHeader_Ljava_lang_String_Ljava_lang_Object_);
			return cb_setHeader_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_SetHeader_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetHeader (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setHeader_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.http']/class[@name='HeaderAndBody']/method[@name='setHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("setHeader", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetSetHeader_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe void SetHeader (string p0, global::Java.Lang.Object p1)
		{
			if (id_setHeader_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_setHeader_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setHeader", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHeader_Ljava_lang_String_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHeader", "(Ljava/lang/String;Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
