using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Pipe.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.http']/class[@name='HttpException']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/http/HttpException", DoNotGenerateAcw=true)]
	public partial class HttpException : global::Java.Lang.RuntimeException {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/pipe/http/HttpException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpException); }
		}

		protected HttpException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayBILjava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.http']/class[@name='HttpException']/constructor[@name='HttpException' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register (".ctor", "([BILjava/lang/String;Ljava/util/Map;)V", "")]
		public unsafe HttpException (byte[] p0, int p1, string p2, global::System.Collections.Generic.IDictionary<string, string> p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				if (((object) this).GetType () != typeof (HttpException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([BILjava/lang/String;Ljava/util/Map;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "([BILjava/lang/String;Ljava/util/Map;)V", __args);
					return;
				}

				if (id_ctor_arrayBILjava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
					id_ctor_arrayBILjava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "([BILjava/lang/String;Ljava/util/Map;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayBILjava_lang_String_Ljava_util_Map_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_arrayBILjava_lang_String_Ljava_util_Map_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_ctor_arrayBILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.http']/class[@name='HttpException']/constructor[@name='HttpException' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "([BILjava/lang/String;)V", "")]
		public unsafe HttpException (byte[] p0, int p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				if (((object) this).GetType () != typeof (HttpException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([BILjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "([BILjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_arrayBILjava_lang_String_ == IntPtr.Zero)
					id_ctor_arrayBILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "([BILjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayBILjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_arrayBILjava_lang_String_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_ctor_arrayBILjava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.http']/class[@name='HttpException']/constructor[@name='HttpException' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register (".ctor", "([BILjava/util/Map;)V", "")]
		public unsafe HttpException (byte[] p0, int p1, global::System.Collections.Generic.IDictionary<string, string> p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				if (((object) this).GetType () != typeof (HttpException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([BILjava/util/Map;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "([BILjava/util/Map;)V", __args);
					return;
				}

				if (id_ctor_arrayBILjava_util_Map_ == IntPtr.Zero)
					id_ctor_arrayBILjava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "([BILjava/util/Map;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayBILjava_util_Map_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_arrayBILjava_util_Map_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_ctor_arrayBI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.http']/class[@name='HttpException']/constructor[@name='HttpException' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register (".ctor", "([BI)V", "")]
		public unsafe HttpException (byte[] p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (HttpException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([BI)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "([BI)V", __args);
					return;
				}

				if (id_ctor_arrayBI == IntPtr.Zero)
					id_ctor_arrayBI = JNIEnv.GetMethodID (class_ref, "<init>", "([BI)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayBI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_arrayBI, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_getHeaders;
#pragma warning disable 0169
		static Delegate GetGetHeadersHandler ()
		{
			if (cb_getHeaders == null)
				cb_getHeaders = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeaders);
			return cb_getHeaders;
		}

		static IntPtr n_GetHeaders (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Http.HttpException __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Http.HttpException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.Headers);
		}
#pragma warning restore 0169

		static IntPtr id_getHeaders;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> Headers {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.http']/class[@name='HttpException']/method[@name='getHeaders' and count(parameter)=0]"
			[Register ("getHeaders", "()Ljava/util/Map;", "GetGetHeadersHandler")]
			get {
				if (id_getHeaders == IntPtr.Zero)
					id_getHeaders = JNIEnv.GetMethodID (class_ref, "getHeaders", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Throwable) this).Handle, id_getHeaders), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Throwable) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeaders", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStatusCode;
#pragma warning disable 0169
		static Delegate GetGetStatusCodeHandler ()
		{
			if (cb_getStatusCode == null)
				cb_getStatusCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStatusCode);
			return cb_getStatusCode;
		}

		static int n_GetStatusCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Http.HttpException __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Http.HttpException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StatusCode;
		}
#pragma warning restore 0169

		static IntPtr id_getStatusCode;
		public virtual unsafe int StatusCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.http']/class[@name='HttpException']/method[@name='getStatusCode' and count(parameter)=0]"
			[Register ("getStatusCode", "()I", "GetGetStatusCodeHandler")]
			get {
				if (id_getStatusCode == IntPtr.Zero)
					id_getStatusCode = JNIEnv.GetMethodID (class_ref, "getStatusCode", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Throwable) this).Handle, id_getStatusCode);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Throwable) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatusCode", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Http.HttpException __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Http.HttpException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetData ());
		}
#pragma warning restore 0169

		static IntPtr id_getData;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.http']/class[@name='HttpException']/method[@name='getData' and count(parameter)=0]"
		[Register ("getData", "()[B", "GetGetDataHandler")]
		public virtual unsafe byte[] GetData ()
		{
			if (id_getData == IntPtr.Zero)
				id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Throwable) this).Handle, id_getData), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Throwable) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getData", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}
}
