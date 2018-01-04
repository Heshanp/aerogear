using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Pipe.Rest {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest']/class[@name='RestRunner']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/rest/RestRunner", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class RestRunner : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/pipe/rest/RestRunner", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RestRunner); }
		}

		protected RestRunner (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Class_Ljava_net_URL_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest']/class[@name='RestRunner']/constructor[@name='RestRunner' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;T&gt;'] and parameter[2][@type='java.net.URL']]"
		[Register (".ctor", "(Ljava/lang/Class;Ljava/net/URL;)V", "")]
		public unsafe RestRunner (global::Java.Lang.Class p0, global::Java.Net.URL p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (RestRunner)) {
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

		static Delegate cb_getRequestBuilder;
#pragma warning disable 0169
		static Delegate GetGetRequestBuilderHandler ()
		{
			if (cb_getRequestBuilder == null)
				cb_getRequestBuilder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestBuilder);
			return cb_getRequestBuilder;
		}

		static IntPtr n_GetRequestBuilder (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestRunner __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RequestBuilder);
		}
#pragma warning restore 0169

		static IntPtr id_getRequestBuilder;
		protected virtual unsafe global::Org.Jboss.Aerogear.Android.Pipe.IRequestBuilder RequestBuilder {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest']/class[@name='RestRunner']/method[@name='getRequestBuilder' and count(parameter)=0]"
			[Register ("getRequestBuilder", "()Lorg/jboss/aerogear/android/pipe/RequestBuilder;", "GetGetRequestBuilderHandler")]
			get {
				if (id_getRequestBuilder == IntPtr.Zero)
					id_getRequestBuilder = JNIEnv.GetMethodID (class_ref, "getRequestBuilder", "()Lorg/jboss/aerogear/android/pipe/RequestBuilder;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.IRequestBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequestBuilder), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.IRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestBuilder", "()Lorg/jboss/aerogear/android/pipe/RequestBuilder;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_onRawSave_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetOnRawSave_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_onRawSave_Ljava_lang_String_arrayB == null)
				cb_onRawSave_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRawSave_Ljava_lang_String_arrayB);
			return cb_onRawSave_Ljava_lang_String_arrayB;
		}

		static IntPtr n_OnRawSave_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestRunner __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnRawSave (p0, p1));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onRawSave_Ljava_lang_String_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest']/class[@name='RestRunner']/method[@name='onRawSave' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("onRawSave", "(Ljava/lang/String;[B)Lorg/jboss/aerogear/android/pipe/http/HeaderAndBody;", "GetOnRawSave_Ljava_lang_String_arrayBHandler")]
		public virtual unsafe global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody OnRawSave (string p0, byte[] p1)
		{
			if (id_onRawSave_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_onRawSave_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "onRawSave", "(Ljava/lang/String;[B)Lorg/jboss/aerogear/android/pipe/http/HeaderAndBody;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onRawSave_Ljava_lang_String_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRawSave", "(Ljava/lang/String;[B)Lorg/jboss/aerogear/android/pipe/http/HeaderAndBody;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_onRemove_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnRemove_Ljava_lang_String_Handler ()
		{
			if (cb_onRemove_Ljava_lang_String_ == null)
				cb_onRemove_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRemove_Ljava_lang_String_);
			return cb_onRemove_Ljava_lang_String_;
		}

		static void n_OnRemove_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestRunner __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRemove (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onRemove_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest']/class[@name='RestRunner']/method[@name='onRemove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onRemove", "(Ljava/lang/String;)V", "GetOnRemove_Ljava_lang_String_Handler")]
		public virtual unsafe void OnRemove (string p0)
		{
			if (id_onRemove_Ljava_lang_String_ == IntPtr.Zero)
				id_onRemove_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onRemove", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRemove_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRemove", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
