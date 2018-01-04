using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Pipe.Module {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.module']/interface[@name='PipeModule']"
	[Register ("org/jboss/aerogear/android/pipe/module/PipeModule", "", "Org.Jboss.Aerogear.Android.Pipe.Module.IPipeModuleInvoker")]
	public partial interface IPipeModule : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.module']/interface[@name='PipeModule']/method[@name='handleError' and count(parameter)=1 and parameter[1][@type='org.jboss.aerogear.android.pipe.http.HttpException']]"
		[Register ("handleError", "(Lorg/jboss/aerogear/android/pipe/http/HttpException;)Z", "GetHandleError_Lorg_jboss_aerogear_android_pipe_http_HttpException_Handler:Org.Jboss.Aerogear.Android.Pipe.Module.IPipeModuleInvoker, Pipe")]
		bool HandleError (global::Org.Jboss.Aerogear.Android.Pipe.Http.HttpException p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.module']/interface[@name='PipeModule']/method[@name='loadModule' and count(parameter)=3 and parameter[1][@type='java.net.URI'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]']]"
		[Register ("loadModule", "(Ljava/net/URI;Ljava/lang/String;[B)Lorg/jboss/aerogear/android/pipe/module/ModuleFields;", "GetLoadModule_Ljava_net_URI_Ljava_lang_String_arrayBHandler:Org.Jboss.Aerogear.Android.Pipe.Module.IPipeModuleInvoker, Pipe")]
		global::Org.Jboss.Aerogear.Android.Pipe.Module.ModuleFields LoadModule (global::Java.Net.URI p0, string p1, byte[] p2);

	}

	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/module/PipeModule", DoNotGenerateAcw=true)]
	internal class IPipeModuleInvoker : global::Java.Lang.Object, IPipeModule {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/jboss/aerogear/android/pipe/module/PipeModule");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IPipeModuleInvoker); }
		}

		IntPtr class_ref;

		public static IPipeModule GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPipeModule> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.jboss.aerogear.android.pipe.module.PipeModule"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPipeModuleInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_handleError_Lorg_jboss_aerogear_android_pipe_http_HttpException_;
#pragma warning disable 0169
		static Delegate GetHandleError_Lorg_jboss_aerogear_android_pipe_http_HttpException_Handler ()
		{
			if (cb_handleError_Lorg_jboss_aerogear_android_pipe_http_HttpException_ == null)
				cb_handleError_Lorg_jboss_aerogear_android_pipe_http_HttpException_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_HandleError_Lorg_jboss_aerogear_android_pipe_http_HttpException_);
			return cb_handleError_Lorg_jboss_aerogear_android_pipe_http_HttpException_;
		}

		static bool n_HandleError_Lorg_jboss_aerogear_android_pipe_http_HttpException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Module.IPipeModule __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Module.IPipeModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jboss.Aerogear.Android.Pipe.Http.HttpException p0 = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Http.HttpException> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HandleError (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_handleError_Lorg_jboss_aerogear_android_pipe_http_HttpException_;
		public unsafe bool HandleError (global::Org.Jboss.Aerogear.Android.Pipe.Http.HttpException p0)
		{
			if (id_handleError_Lorg_jboss_aerogear_android_pipe_http_HttpException_ == IntPtr.Zero)
				id_handleError_Lorg_jboss_aerogear_android_pipe_http_HttpException_ = JNIEnv.GetMethodID (class_ref, "handleError", "(Lorg/jboss/aerogear/android/pipe/http/HttpException;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_handleError_Lorg_jboss_aerogear_android_pipe_http_HttpException_, __args);
			return __ret;
		}

		static Delegate cb_loadModule_Ljava_net_URI_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetLoadModule_Ljava_net_URI_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_loadModule_Ljava_net_URI_Ljava_lang_String_arrayB == null)
				cb_loadModule_Ljava_net_URI_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadModule_Ljava_net_URI_Ljava_lang_String_arrayB);
			return cb_loadModule_Ljava_net_URI_Ljava_lang_String_arrayB;
		}

		static IntPtr n_LoadModule_Ljava_net_URI_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Module.IPipeModule __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Module.IPipeModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.URI p0 = global::Java.Lang.Object.GetObject<global::Java.Net.URI> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LoadModule (p0, p1, p2));
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_loadModule_Ljava_net_URI_Ljava_lang_String_arrayB;
		public unsafe global::Org.Jboss.Aerogear.Android.Pipe.Module.ModuleFields LoadModule (global::Java.Net.URI p0, string p1, byte[] p2)
		{
			if (id_loadModule_Ljava_net_URI_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_loadModule_Ljava_net_URI_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "loadModule", "(Ljava/net/URI;Ljava/lang/String;[B)Lorg/jboss/aerogear/android/pipe/module/ModuleFields;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			global::Org.Jboss.Aerogear.Android.Pipe.Module.ModuleFields __ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Module.ModuleFields> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_loadModule_Ljava_net_URI_Ljava_lang_String_arrayB, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

	}

}
