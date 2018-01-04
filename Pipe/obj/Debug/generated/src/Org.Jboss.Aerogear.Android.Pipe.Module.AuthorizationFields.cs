using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Pipe.Module {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.module']/class[@name='AuthorizationFields']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/module/AuthorizationFields", DoNotGenerateAcw=true)]
	public sealed partial class AuthorizationFields : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/pipe/module/AuthorizationFields", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AuthorizationFields); }
		}

		internal AuthorizationFields (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.module']/class[@name='AuthorizationFields']/constructor[@name='AuthorizationFields' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AuthorizationFields ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AuthorizationFields)) {
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

		static IntPtr id_getHeaders;
		static IntPtr id_setHeaders_Ljava_util_List_;
		public unsafe global::System.Collections.Generic.IList<global::Android.Util.Pair> Headers {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.module']/class[@name='AuthorizationFields']/method[@name='getHeaders' and count(parameter)=0]"
			[Register ("getHeaders", "()Ljava/util/List;", "GetGetHeadersHandler")]
			get {
				if (id_getHeaders == IntPtr.Zero)
					id_getHeaders = JNIEnv.GetMethodID (class_ref, "getHeaders", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<global::Android.Util.Pair>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHeaders), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.module']/class[@name='AuthorizationFields']/method[@name='setHeaders' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;android.util.Pair&lt;java.lang.String, java.lang.String&gt;&gt;']]"
			[Register ("setHeaders", "(Ljava/util/List;)V", "GetSetHeaders_Ljava_util_List_Handler")]
			set {
				if (id_setHeaders_Ljava_util_List_ == IntPtr.Zero)
					id_setHeaders_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setHeaders", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Android.Util.Pair>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHeaders_Ljava_util_List_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getQueryParameters;
		static IntPtr id_setQueryParameters_Ljava_util_List_;
		public unsafe global::System.Collections.Generic.IList<global::Android.Util.Pair> QueryParameters {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.module']/class[@name='AuthorizationFields']/method[@name='getQueryParameters' and count(parameter)=0]"
			[Register ("getQueryParameters", "()Ljava/util/List;", "GetGetQueryParametersHandler")]
			get {
				if (id_getQueryParameters == IntPtr.Zero)
					id_getQueryParameters = JNIEnv.GetMethodID (class_ref, "getQueryParameters", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<global::Android.Util.Pair>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getQueryParameters), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.module']/class[@name='AuthorizationFields']/method[@name='setQueryParameters' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;android.util.Pair&lt;java.lang.String, java.lang.String&gt;&gt;']]"
			[Register ("setQueryParameters", "(Ljava/util/List;)V", "GetSetQueryParameters_Ljava_util_List_Handler")]
			set {
				if (id_setQueryParameters_Ljava_util_List_ == IntPtr.Zero)
					id_setQueryParameters_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setQueryParameters", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Android.Util.Pair>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setQueryParameters_Ljava_util_List_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_addHeader_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.module']/class[@name='AuthorizationFields']/method[@name='addHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addHeader", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void AddHeader (string p0, string p1)
		{
			if (id_addHeader_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addHeader_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addHeader_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_addQueryParameter_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.module']/class[@name='AuthorizationFields']/method[@name='addQueryParameter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addQueryParameter", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void AddQueryParameter (string p0, string p1)
		{
			if (id_addQueryParameter_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addQueryParameter_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addQueryParameter", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addQueryParameter_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
