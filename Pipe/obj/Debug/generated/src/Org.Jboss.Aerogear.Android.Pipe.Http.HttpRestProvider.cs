using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Pipe.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.http']/class[@name='HttpRestProvider']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/http/HttpRestProvider", DoNotGenerateAcw=true)]
	public sealed partial class HttpRestProvider : global::Java.Lang.Object, global::Org.Jboss.Aerogear.Android.Pipe.Http.IHttpProvider {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/pipe/http/HttpRestProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpRestProvider); }
		}

		internal HttpRestProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_net_URL_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.http']/class[@name='HttpRestProvider']/constructor[@name='HttpRestProvider' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
		[Register (".ctor", "(Ljava/net/URL;)V", "")]
		public unsafe HttpRestProvider (global::Java.Net.URL p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (HttpRestProvider)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/net/URL;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/net/URL;)V", __args);
					return;
				}

				if (id_ctor_Ljava_net_URL_ == IntPtr.Zero)
					id_ctor_Ljava_net_URL_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/net/URL;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_net_URL_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_net_URL_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_net_URL_Ljava_lang_Integer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.http']/class[@name='HttpRestProvider']/constructor[@name='HttpRestProvider' and count(parameter)=2 and parameter[1][@type='java.net.URL'] and parameter[2][@type='java.lang.Integer']]"
		[Register (".ctor", "(Ljava/net/URL;Ljava/lang/Integer;)V", "")]
		public unsafe HttpRestProvider (global::Java.Net.URL p0, global::Java.Lang.Integer p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (HttpRestProvider)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/net/URL;Ljava/lang/Integer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/net/URL;Ljava/lang/Integer;)V", __args);
					return;
				}

				if (id_ctor_Ljava_net_URL_Ljava_lang_Integer_ == IntPtr.Zero)
					id_ctor_Ljava_net_URL_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/net/URL;Ljava/lang/Integer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_net_URL_Ljava_lang_Integer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_net_URL_Ljava_lang_Integer_, __args);
			} finally {
			}
		}

		static IntPtr id_getUrl;
		public unsafe global::Java.Net.URL Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.http']/class[@name='HttpRestProvider']/method[@name='getUrl' and count(parameter)=0]"
			[Register ("getUrl", "()Ljava/net/URL;", "GetGetUrlHandler")]
			get {
				if (id_getUrl == IntPtr.Zero)
					id_getUrl = JNIEnv.GetMethodID (class_ref, "getUrl", "()Ljava/net/URL;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Net.URL> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUrl), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_delete_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.http']/class[@name='HttpRestProvider']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("delete", "(Ljava/lang/String;)Lorg/jboss/aerogear/android/pipe/http/HeaderAndBody;", "")]
		public unsafe global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody Delete (string p0)
		{
			if (id_delete_Ljava_lang_String_ == IntPtr.Zero)
				id_delete_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "delete", "(Ljava/lang/String;)Lorg/jboss/aerogear/android/pipe/http/HeaderAndBody;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody __ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_delete_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_get;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.http']/class[@name='HttpRestProvider']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Lorg/jboss/aerogear/android/pipe/http/HeaderAndBody;", "")]
		public unsafe global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetMethodID (class_ref, "get", "()Lorg/jboss/aerogear/android/pipe/http/HeaderAndBody;");
			try {
				return global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_post_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.http']/class[@name='HttpRestProvider']/method[@name='post' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("post", "([B)Lorg/jboss/aerogear/android/pipe/http/HeaderAndBody;", "")]
		public unsafe global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody Post (byte[] p0)
		{
			if (id_post_arrayB == IntPtr.Zero)
				id_post_arrayB = JNIEnv.GetMethodID (class_ref, "post", "([B)Lorg/jboss/aerogear/android/pipe/http/HeaderAndBody;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody __ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_post_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_post_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.http']/class[@name='HttpRestProvider']/method[@name='post' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("post", "(Ljava/lang/String;)Lorg/jboss/aerogear/android/pipe/http/HeaderAndBody;", "")]
		public unsafe global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody Post (string p0)
		{
			if (id_post_Ljava_lang_String_ == IntPtr.Zero)
				id_post_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "post", "(Ljava/lang/String;)Lorg/jboss/aerogear/android/pipe/http/HeaderAndBody;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody __ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_post_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_put_Ljava_lang_String_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.http']/class[@name='HttpRestProvider']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("put", "(Ljava/lang/String;[B)Lorg/jboss/aerogear/android/pipe/http/HeaderAndBody;", "")]
		public unsafe global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody Put (string p0, byte[] p1)
		{
			if (id_put_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_put_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;[B)Lorg/jboss/aerogear/android/pipe/http/HeaderAndBody;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody __ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_put_Ljava_lang_String_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_put_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.http']/class[@name='HttpRestProvider']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("put", "(Ljava/lang/String;Ljava/lang/String;)Lorg/jboss/aerogear/android/pipe/http/HeaderAndBody;", "")]
		public unsafe global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody Put (string p0, string p1)
		{
			if (id_put_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_put_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Ljava/lang/String;)Lorg/jboss/aerogear/android/pipe/http/HeaderAndBody;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody __ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_put_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setDefaultHeader_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.http']/class[@name='HttpRestProvider']/method[@name='setDefaultHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setDefaultHeader", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void SetDefaultHeader (string p0, string p1)
		{
			if (id_setDefaultHeader_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setDefaultHeader_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDefaultHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDefaultHeader_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
