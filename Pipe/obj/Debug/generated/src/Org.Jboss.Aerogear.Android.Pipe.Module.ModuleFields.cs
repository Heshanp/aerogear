using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Pipe.Module {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.module']/class[@name='ModuleFields']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/module/ModuleFields", DoNotGenerateAcw=true)]
	public partial class ModuleFields : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/pipe/module/ModuleFields", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ModuleFields); }
		}

		protected ModuleFields (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.module']/class[@name='ModuleFields']/constructor[@name='ModuleFields' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ModuleFields ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ModuleFields)) {
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
			global::Org.Jboss.Aerogear.Android.Pipe.Module.ModuleFields __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Module.ModuleFields> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Util.Pair>.ToLocalJniHandle (__this.Headers);
		}
#pragma warning restore 0169

		static Delegate cb_setHeaders_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetHeaders_Ljava_util_List_Handler ()
		{
			if (cb_setHeaders_Ljava_util_List_ == null)
				cb_setHeaders_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHeaders_Ljava_util_List_);
			return cb_setHeaders_Ljava_util_List_;
		}

		static void n_SetHeaders_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Module.ModuleFields __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Module.ModuleFields> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Android.Util.Pair>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Headers = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHeaders;
		static IntPtr id_setHeaders_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Android.Util.Pair> Headers {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.module']/class[@name='ModuleFields']/method[@name='getHeaders' and count(parameter)=0]"
			[Register ("getHeaders", "()Ljava/util/List;", "GetGetHeadersHandler")]
			get {
				if (id_getHeaders == IntPtr.Zero)
					id_getHeaders = JNIEnv.GetMethodID (class_ref, "getHeaders", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Android.Util.Pair>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHeaders), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Android.Util.Pair>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeaders", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.module']/class[@name='ModuleFields']/method[@name='setHeaders' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;android.util.Pair&lt;java.lang.String, java.lang.String&gt;&gt;']]"
			[Register ("setHeaders", "(Ljava/util/List;)V", "GetSetHeaders_Ljava_util_List_Handler")]
			set {
				if (id_setHeaders_Ljava_util_List_ == IntPtr.Zero)
					id_setHeaders_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setHeaders", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Android.Util.Pair>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHeaders_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHeaders", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getQueryParameters;
#pragma warning disable 0169
		static Delegate GetGetQueryParametersHandler ()
		{
			if (cb_getQueryParameters == null)
				cb_getQueryParameters = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetQueryParameters);
			return cb_getQueryParameters;
		}

		static IntPtr n_GetQueryParameters (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Module.ModuleFields __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Module.ModuleFields> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Util.Pair>.ToLocalJniHandle (__this.QueryParameters);
		}
#pragma warning restore 0169

		static Delegate cb_setQueryParameters_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetQueryParameters_Ljava_util_List_Handler ()
		{
			if (cb_setQueryParameters_Ljava_util_List_ == null)
				cb_setQueryParameters_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetQueryParameters_Ljava_util_List_);
			return cb_setQueryParameters_Ljava_util_List_;
		}

		static void n_SetQueryParameters_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Module.ModuleFields __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Module.ModuleFields> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Android.Util.Pair>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.QueryParameters = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getQueryParameters;
		static IntPtr id_setQueryParameters_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Android.Util.Pair> QueryParameters {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.module']/class[@name='ModuleFields']/method[@name='getQueryParameters' and count(parameter)=0]"
			[Register ("getQueryParameters", "()Ljava/util/List;", "GetGetQueryParametersHandler")]
			get {
				if (id_getQueryParameters == IntPtr.Zero)
					id_getQueryParameters = JNIEnv.GetMethodID (class_ref, "getQueryParameters", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Android.Util.Pair>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getQueryParameters), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Android.Util.Pair>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getQueryParameters", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.module']/class[@name='ModuleFields']/method[@name='setQueryParameters' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;android.util.Pair&lt;java.lang.String, java.lang.String&gt;&gt;']]"
			[Register ("setQueryParameters", "(Ljava/util/List;)V", "GetSetQueryParameters_Ljava_util_List_Handler")]
			set {
				if (id_setQueryParameters_Ljava_util_List_ == IntPtr.Zero)
					id_setQueryParameters_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setQueryParameters", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Android.Util.Pair>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setQueryParameters_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setQueryParameters", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_addHeader_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddHeader_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addHeader_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addHeader_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddHeader_Ljava_lang_String_Ljava_lang_String_);
			return cb_addHeader_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_AddHeader_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Module.ModuleFields __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Module.ModuleFields> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddHeader (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addHeader_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.module']/class[@name='ModuleFields']/method[@name='addHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addHeader", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAddHeader_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void AddHeader (string p0, string p1)
		{
			if (id_addHeader_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addHeader_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addHeader_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_addQueryParameter_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddQueryParameter_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addQueryParameter_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addQueryParameter_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddQueryParameter_Ljava_lang_String_Ljava_lang_String_);
			return cb_addQueryParameter_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_AddQueryParameter_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Module.ModuleFields __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Module.ModuleFields> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddQueryParameter (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addQueryParameter_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.module']/class[@name='ModuleFields']/method[@name='addQueryParameter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addQueryParameter", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAddQueryParameter_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void AddQueryParameter (string p0, string p1)
		{
			if (id_addQueryParameter_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addQueryParameter_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addQueryParameter", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addQueryParameter_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addQueryParameter", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
