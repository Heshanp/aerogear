using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Pipe.Http {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.http']/interface[@name='HttpProvider']"
	[Register ("org/jboss/aerogear/android/pipe/http/HttpProvider", "", "Org.Jboss.Aerogear.Android.Pipe.Http.IHttpProviderInvoker")]
	public partial interface IHttpProvider : IJavaObject {

		global::Java.Net.URL Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.http']/interface[@name='HttpProvider']/method[@name='getUrl' and count(parameter)=0]"
			[Register ("getUrl", "()Ljava/net/URL;", "GetGetUrlHandler:Org.Jboss.Aerogear.Android.Pipe.Http.IHttpProviderInvoker, Pipe")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.http']/interface[@name='HttpProvider']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("delete", "(Ljava/lang/String;)Lorg/jboss/aerogear/android/pipe/http/HeaderAndBody;", "GetDelete_Ljava_lang_String_Handler:Org.Jboss.Aerogear.Android.Pipe.Http.IHttpProviderInvoker, Pipe")]
		global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody Delete (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.http']/interface[@name='HttpProvider']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Lorg/jboss/aerogear/android/pipe/http/HeaderAndBody;", "GetGetHandler:Org.Jboss.Aerogear.Android.Pipe.Http.IHttpProviderInvoker, Pipe")]
		global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody Get ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.http']/interface[@name='HttpProvider']/method[@name='post' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("post", "([B)Lorg/jboss/aerogear/android/pipe/http/HeaderAndBody;", "GetPost_arrayBHandler:Org.Jboss.Aerogear.Android.Pipe.Http.IHttpProviderInvoker, Pipe")]
		global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody Post (byte[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.http']/interface[@name='HttpProvider']/method[@name='post' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("post", "(Ljava/lang/String;)Lorg/jboss/aerogear/android/pipe/http/HeaderAndBody;", "GetPost_Ljava_lang_String_Handler:Org.Jboss.Aerogear.Android.Pipe.Http.IHttpProviderInvoker, Pipe")]
		global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody Post (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.http']/interface[@name='HttpProvider']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("put", "(Ljava/lang/String;[B)Lorg/jboss/aerogear/android/pipe/http/HeaderAndBody;", "GetPut_Ljava_lang_String_arrayBHandler:Org.Jboss.Aerogear.Android.Pipe.Http.IHttpProviderInvoker, Pipe")]
		global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody Put (string p0, byte[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.http']/interface[@name='HttpProvider']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("put", "(Ljava/lang/String;Ljava/lang/String;)Lorg/jboss/aerogear/android/pipe/http/HeaderAndBody;", "GetPut_Ljava_lang_String_Ljava_lang_String_Handler:Org.Jboss.Aerogear.Android.Pipe.Http.IHttpProviderInvoker, Pipe")]
		global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody Put (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.http']/interface[@name='HttpProvider']/method[@name='setDefaultHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setDefaultHeader", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetDefaultHeader_Ljava_lang_String_Ljava_lang_String_Handler:Org.Jboss.Aerogear.Android.Pipe.Http.IHttpProviderInvoker, Pipe")]
		void SetDefaultHeader (string p0, string p1);

	}

	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/http/HttpProvider", DoNotGenerateAcw=true)]
	internal class IHttpProviderInvoker : global::Java.Lang.Object, IHttpProvider {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/jboss/aerogear/android/pipe/http/HttpProvider");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IHttpProviderInvoker); }
		}

		IntPtr class_ref;

		public static IHttpProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHttpProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.jboss.aerogear.android.pipe.http.HttpProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHttpProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getUrl;
#pragma warning disable 0169
		static Delegate GetGetUrlHandler ()
		{
			if (cb_getUrl == null)
				cb_getUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUrl);
			return cb_getUrl;
		}

		static IntPtr n_GetUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Http.IHttpProvider __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Http.IHttpProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Url);
		}
#pragma warning restore 0169

		IntPtr id_getUrl;
		public unsafe global::Java.Net.URL Url {
			get {
				if (id_getUrl == IntPtr.Zero)
					id_getUrl = JNIEnv.GetMethodID (class_ref, "getUrl", "()Ljava/net/URL;");
				return global::Java.Lang.Object.GetObject<global::Java.Net.URL> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUrl), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_delete_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDelete_Ljava_lang_String_Handler ()
		{
			if (cb_delete_Ljava_lang_String_ == null)
				cb_delete_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Delete_Ljava_lang_String_);
			return cb_delete_Ljava_lang_String_;
		}

		static IntPtr n_Delete_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Http.IHttpProvider __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Http.IHttpProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Delete (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_delete_Ljava_lang_String_;
		public unsafe global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody Delete (string p0)
		{
			if (id_delete_Ljava_lang_String_ == IntPtr.Zero)
				id_delete_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "delete", "(Ljava/lang/String;)Lorg/jboss/aerogear/android/pipe/http/HeaderAndBody;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody __ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_delete_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_get;
#pragma warning disable 0169
		static Delegate GetGetHandler ()
		{
			if (cb_get == null)
				cb_get = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get);
			return cb_get;
		}

		static IntPtr n_Get (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Http.IHttpProvider __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Http.IHttpProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get ());
		}
#pragma warning restore 0169

		IntPtr id_get;
		public unsafe global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetMethodID (class_ref, "get", "()Lorg/jboss/aerogear/android/pipe/http/HeaderAndBody;");
			return global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_post_arrayB;
#pragma warning disable 0169
		static Delegate GetPost_arrayBHandler ()
		{
			if (cb_post_arrayB == null)
				cb_post_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Post_arrayB);
			return cb_post_arrayB;
		}

		static IntPtr n_Post_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Http.IHttpProvider __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Http.IHttpProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Post (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_post_arrayB;
		public unsafe global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody Post (byte[] p0)
		{
			if (id_post_arrayB == IntPtr.Zero)
				id_post_arrayB = JNIEnv.GetMethodID (class_ref, "post", "([B)Lorg/jboss/aerogear/android/pipe/http/HeaderAndBody;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody __ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_post_arrayB, __args), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_post_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPost_Ljava_lang_String_Handler ()
		{
			if (cb_post_Ljava_lang_String_ == null)
				cb_post_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Post_Ljava_lang_String_);
			return cb_post_Ljava_lang_String_;
		}

		static IntPtr n_Post_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Http.IHttpProvider __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Http.IHttpProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Post (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_post_Ljava_lang_String_;
		public unsafe global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody Post (string p0)
		{
			if (id_post_Ljava_lang_String_ == IntPtr.Zero)
				id_post_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "post", "(Ljava/lang/String;)Lorg/jboss/aerogear/android/pipe/http/HeaderAndBody;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody __ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_post_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_put_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_put_Ljava_lang_String_arrayB == null)
				cb_put_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_String_arrayB);
			return cb_put_Ljava_lang_String_arrayB;
		}

		static IntPtr n_Put_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Http.IHttpProvider __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Http.IHttpProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Put (p0, p1));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_put_Ljava_lang_String_arrayB;
		public unsafe global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody Put (string p0, byte[] p1)
		{
			if (id_put_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_put_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;[B)Lorg/jboss/aerogear/android/pipe/http/HeaderAndBody;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody __ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_put_Ljava_lang_String_arrayB, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_put_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_put_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_put_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_String_Ljava_lang_String_);
			return cb_put_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Put_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Http.IHttpProvider __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Http.IHttpProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Put (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_put_Ljava_lang_String_Ljava_lang_String_;
		public unsafe global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody Put (string p0, string p1)
		{
			if (id_put_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_put_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Ljava/lang/String;)Lorg/jboss/aerogear/android/pipe/http/HeaderAndBody;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody __ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_put_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_setDefaultHeader_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDefaultHeader_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setDefaultHeader_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setDefaultHeader_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetDefaultHeader_Ljava_lang_String_Ljava_lang_String_);
			return cb_setDefaultHeader_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetDefaultHeader_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Http.IHttpProvider __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Http.IHttpProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetDefaultHeader (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setDefaultHeader_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void SetDefaultHeader (string p0, string p1)
		{
			if (id_setDefaultHeader_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setDefaultHeader_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDefaultHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDefaultHeader_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
