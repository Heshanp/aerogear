using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Pipe {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.jboss.aerogear.android.pipe']/interface[@name='ResponseParser']"
	[Register ("org/jboss/aerogear/android/pipe/ResponseParser", "", "Org.Jboss.Aerogear.Android.Pipe.IResponseParserInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IResponseParser : IJavaObject {

		global::Org.Jboss.Aerogear.Android.Pipe.MarshallingConfig MarshallingConfig {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe']/interface[@name='ResponseParser']/method[@name='getMarshallingConfig' and count(parameter)=0]"
			[Register ("getMarshallingConfig", "()Lorg/jboss/aerogear/android/pipe/MarshallingConfig;", "GetGetMarshallingConfigHandler:Org.Jboss.Aerogear.Android.Pipe.IResponseParserInvoker, Pipe")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe']/interface[@name='ResponseParser']/method[@name='handleResponse' and count(parameter)=2 and parameter[1][@type='org.jboss.aerogear.android.pipe.http.HeaderAndBody'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("handleResponse", "(Lorg/jboss/aerogear/android/pipe/http/HeaderAndBody;Ljava/lang/Class;)Ljava/util/List;", "GetHandleResponse_Lorg_jboss_aerogear_android_pipe_http_HeaderAndBody_Ljava_lang_Class_Handler:Org.Jboss.Aerogear.Android.Pipe.IResponseParserInvoker, Pipe")]
		global::System.Collections.IList HandleResponse (global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody p0, global::Java.Lang.Class p1);

	}

	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/ResponseParser", DoNotGenerateAcw=true)]
	internal class IResponseParserInvoker : global::Java.Lang.Object, IResponseParser {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/jboss/aerogear/android/pipe/ResponseParser");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IResponseParserInvoker); }
		}

		IntPtr class_ref;

		public static IResponseParser GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IResponseParser> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.jboss.aerogear.android.pipe.ResponseParser"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IResponseParserInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getMarshallingConfig;
#pragma warning disable 0169
		static Delegate GetGetMarshallingConfigHandler ()
		{
			if (cb_getMarshallingConfig == null)
				cb_getMarshallingConfig = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMarshallingConfig);
			return cb_getMarshallingConfig;
		}

		static IntPtr n_GetMarshallingConfig (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.IResponseParser __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.IResponseParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MarshallingConfig);
		}
#pragma warning restore 0169

		IntPtr id_getMarshallingConfig;
		public unsafe global::Org.Jboss.Aerogear.Android.Pipe.MarshallingConfig MarshallingConfig {
			get {
				if (id_getMarshallingConfig == IntPtr.Zero)
					id_getMarshallingConfig = JNIEnv.GetMethodID (class_ref, "getMarshallingConfig", "()Lorg/jboss/aerogear/android/pipe/MarshallingConfig;");
				return global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.MarshallingConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMarshallingConfig), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_handleResponse_Lorg_jboss_aerogear_android_pipe_http_HeaderAndBody_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetHandleResponse_Lorg_jboss_aerogear_android_pipe_http_HeaderAndBody_Ljava_lang_Class_Handler ()
		{
			if (cb_handleResponse_Lorg_jboss_aerogear_android_pipe_http_HeaderAndBody_Ljava_lang_Class_ == null)
				cb_handleResponse_Lorg_jboss_aerogear_android_pipe_http_HeaderAndBody_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_HandleResponse_Lorg_jboss_aerogear_android_pipe_http_HeaderAndBody_Ljava_lang_Class_);
			return cb_handleResponse_Lorg_jboss_aerogear_android_pipe_http_HeaderAndBody_Ljava_lang_Class_;
		}

		static IntPtr n_HandleResponse_Lorg_jboss_aerogear_android_pipe_http_HeaderAndBody_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.IResponseParser __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.IResponseParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody p0 = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList.ToLocalJniHandle (__this.HandleResponse (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_handleResponse_Lorg_jboss_aerogear_android_pipe_http_HeaderAndBody_Ljava_lang_Class_;
		public unsafe global::System.Collections.IList HandleResponse (global::Org.Jboss.Aerogear.Android.Pipe.Http.HeaderAndBody p0, global::Java.Lang.Class p1)
		{
			if (id_handleResponse_Lorg_jboss_aerogear_android_pipe_http_HeaderAndBody_Ljava_lang_Class_ == IntPtr.Zero)
				id_handleResponse_Lorg_jboss_aerogear_android_pipe_http_HeaderAndBody_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "handleResponse", "(Lorg/jboss/aerogear/android/pipe/http/HeaderAndBody;Ljava/lang/Class;)Ljava/util/List;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			global::System.Collections.IList __ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_handleResponse_Lorg_jboss_aerogear_android_pipe_http_HeaderAndBody_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
