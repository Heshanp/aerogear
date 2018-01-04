using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Pipe.Rest {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest']/class[@name='RestAdapter']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/rest/RestAdapter", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class RestAdapter : global::Java.Lang.Object {


		static IntPtr THREAD_POOL_EXECUTOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest']/class[@name='RestAdapter']/field[@name='THREAD_POOL_EXECUTOR']"
		[Register ("THREAD_POOL_EXECUTOR")]
		public static global::Java.Util.Concurrent.IExecutor ThreadPoolExecutor {
			get {
				if (THREAD_POOL_EXECUTOR_jfieldId == IntPtr.Zero)
					THREAD_POOL_EXECUTOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "THREAD_POOL_EXECUTOR", "Ljava/util/concurrent/Executor;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, THREAD_POOL_EXECUTOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutor> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/pipe/rest/RestAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RestAdapter); }
		}

		internal RestAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Class_Ljava_net_URL_Lorg_jboss_aerogear_android_pipe_rest_RestfulPipeConfiguration_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest']/class[@name='RestAdapter']/constructor[@name='RestAdapter' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;T&gt;'] and parameter[2][@type='java.net.URL'] and parameter[3][@type='org.jboss.aerogear.android.pipe.rest.RestfulPipeConfiguration']]"
		[Register (".ctor", "(Ljava/lang/Class;Ljava/net/URL;Lorg/jboss/aerogear/android/pipe/rest/RestfulPipeConfiguration;)V", "")]
		public unsafe RestAdapter (global::Java.Lang.Class p0, global::Java.Net.URL p1, global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (RestAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Class;Ljava/net/URL;Lorg/jboss/aerogear/android/pipe/rest/RestfulPipeConfiguration;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Class;Ljava/net/URL;Lorg/jboss/aerogear/android/pipe/rest/RestfulPipeConfiguration;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Class_Ljava_net_URL_Lorg_jboss_aerogear_android_pipe_rest_RestfulPipeConfiguration_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Class_Ljava_net_URL_Lorg_jboss_aerogear_android_pipe_rest_RestfulPipeConfiguration_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Class;Ljava/net/URL;Lorg/jboss/aerogear/android/pipe/rest/RestfulPipeConfiguration;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Class_Ljava_net_URL_Lorg_jboss_aerogear_android_pipe_rest_RestfulPipeConfiguration_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Class_Ljava_net_URL_Lorg_jboss_aerogear_android_pipe_rest_RestfulPipeConfiguration_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_Class_Ljava_net_URL_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest']/class[@name='RestAdapter']/constructor[@name='RestAdapter' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;T&gt;'] and parameter[2][@type='java.net.URL']]"
		[Register (".ctor", "(Ljava/lang/Class;Ljava/net/URL;)V", "")]
		public unsafe RestAdapter (global::Java.Lang.Class p0, global::Java.Net.URL p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (RestAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Class;Ljava/net/URL;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Class;Ljava/net/URL;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Class_Ljava_net_URL_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Class_Ljava_net_URL_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Class;Ljava/net/URL;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Class_Ljava_net_URL_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Class_Ljava_net_URL_, __args);
			} finally {
			}
		}

		static IntPtr id_getKlass;
		public unsafe global::Java.Lang.Class Klass {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest']/class[@name='RestAdapter']/method[@name='getKlass' and count(parameter)=0]"
			[Register ("getKlass", "()Ljava/lang/Class;", "GetGetKlassHandler")]
			get {
				if (id_getKlass == IntPtr.Zero)
					id_getKlass = JNIEnv.GetMethodID (class_ref, "getKlass", "()Ljava/lang/Class;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKlass), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getRequestBuilder;
		public unsafe global::Org.Jboss.Aerogear.Android.Pipe.IRequestBuilder RequestBuilder {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest']/class[@name='RestAdapter']/method[@name='getRequestBuilder' and count(parameter)=0]"
			[Register ("getRequestBuilder", "()Lorg/jboss/aerogear/android/pipe/RequestBuilder;", "GetGetRequestBuilderHandler")]
			get {
				if (id_getRequestBuilder == IntPtr.Zero)
					id_getRequestBuilder = JNIEnv.GetMethodID (class_ref, "getRequestBuilder", "()Lorg/jboss/aerogear/android/pipe/RequestBuilder;");
				try {
					return global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.IRequestBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequestBuilder), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getResponseParser;
		public unsafe global::Org.Jboss.Aerogear.Android.Pipe.IResponseParser ResponseParser {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest']/class[@name='RestAdapter']/method[@name='getResponseParser' and count(parameter)=0]"
			[Register ("getResponseParser", "()Lorg/jboss/aerogear/android/pipe/ResponseParser;", "GetGetResponseParserHandler")]
			get {
				if (id_getResponseParser == IntPtr.Zero)
					id_getResponseParser = JNIEnv.GetMethodID (class_ref, "getResponseParser", "()Lorg/jboss/aerogear/android/pipe/ResponseParser;");
				try {
					return global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.IResponseParser> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponseParser), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getUrl;
		public unsafe global::Java.Net.URL Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest']/class[@name='RestAdapter']/method[@name='getUrl' and count(parameter)=0]"
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

	}
}
