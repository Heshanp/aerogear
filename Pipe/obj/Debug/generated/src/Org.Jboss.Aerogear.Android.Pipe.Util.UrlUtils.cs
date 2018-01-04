using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Pipe.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.util']/class[@name='UrlUtils']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/util/UrlUtils", DoNotGenerateAcw=true)]
	public sealed partial class UrlUtils : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/pipe/util/UrlUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UrlUtils); }
		}

		internal UrlUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_appendQueryToBaseURL_Ljava_net_URL_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.util']/class[@name='UrlUtils']/method[@name='appendQueryToBaseURL' and count(parameter)=2 and parameter[1][@type='java.net.URL'] and parameter[2][@type='java.lang.String']]"
		[Register ("appendQueryToBaseURL", "(Ljava/net/URL;Ljava/lang/String;)Ljava/net/URL;", "")]
		public static unsafe global::Java.Net.URL AppendQueryToBaseURL (global::Java.Net.URL p0, string p1)
		{
			if (id_appendQueryToBaseURL_Ljava_net_URL_Ljava_lang_String_ == IntPtr.Zero)
				id_appendQueryToBaseURL_Ljava_net_URL_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "appendQueryToBaseURL", "(Ljava/net/URL;Ljava/lang/String;)Ljava/net/URL;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Java.Net.URL __ret = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (JNIEnv.CallStaticObjectMethod  (class_ref, id_appendQueryToBaseURL_Ljava_net_URL_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_appendToBaseURL_Ljava_net_URL_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.util']/class[@name='UrlUtils']/method[@name='appendToBaseURL' and count(parameter)=2 and parameter[1][@type='java.net.URL'] and parameter[2][@type='java.lang.String']]"
		[Register ("appendToBaseURL", "(Ljava/net/URL;Ljava/lang/String;)Ljava/net/URL;", "")]
		public static unsafe global::Java.Net.URL AppendToBaseURL (global::Java.Net.URL p0, string p1)
		{
			if (id_appendToBaseURL_Ljava_net_URL_Ljava_lang_String_ == IntPtr.Zero)
				id_appendToBaseURL_Ljava_net_URL_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "appendToBaseURL", "(Ljava/net/URL;Ljava/lang/String;)Ljava/net/URL;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Java.Net.URL __ret = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (JNIEnv.CallStaticObjectMethod  (class_ref, id_appendToBaseURL_Ljava_net_URL_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
