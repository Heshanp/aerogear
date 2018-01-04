using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Pipe {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.jboss.aerogear.android.pipe']/interface[@name='RequestBuilder']"
	[Register ("org/jboss/aerogear/android/pipe/RequestBuilder", "", "Org.Jboss.Aerogear.Android.Pipe.IRequestBuilderInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IRequestBuilder : IJavaObject {

		string ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe']/interface[@name='RequestBuilder']/method[@name='getContentType' and count(parameter)=0]"
			[Register ("getContentType", "()Ljava/lang/String;", "GetGetContentTypeHandler:Org.Jboss.Aerogear.Android.Pipe.IRequestBuilderInvoker, Pipe")] get;
		}

		global::Org.Jboss.Aerogear.Android.Pipe.MarshallingConfig MarshallingConfig {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe']/interface[@name='RequestBuilder']/method[@name='getMarshallingConfig' and count(parameter)=0]"
			[Register ("getMarshallingConfig", "()Lorg/jboss/aerogear/android/pipe/MarshallingConfig;", "GetGetMarshallingConfigHandler:Org.Jboss.Aerogear.Android.Pipe.IRequestBuilderInvoker, Pipe")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe']/interface[@name='RequestBuilder']/method[@name='getBody' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("getBody", "(Ljava/lang/Object;)[B", "GetGetBody_Ljava_lang_Object_Handler:Org.Jboss.Aerogear.Android.Pipe.IRequestBuilderInvoker, Pipe")]
		byte[] GetBody (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/RequestBuilder", DoNotGenerateAcw=true)]
	internal class IRequestBuilderInvoker : global::Java.Lang.Object, IRequestBuilder {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/jboss/aerogear/android/pipe/RequestBuilder");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IRequestBuilderInvoker); }
		}

		IntPtr class_ref;

		public static IRequestBuilder GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRequestBuilder> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.jboss.aerogear.android.pipe.RequestBuilder"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRequestBuilderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getContentType;
#pragma warning disable 0169
		static Delegate GetGetContentTypeHandler ()
		{
			if (cb_getContentType == null)
				cb_getContentType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentType);
			return cb_getContentType;
		}

		static IntPtr n_GetContentType (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.IRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.IRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentType);
		}
#pragma warning restore 0169

		IntPtr id_getContentType;
		public unsafe string ContentType {
			get {
				if (id_getContentType == IntPtr.Zero)
					id_getContentType = JNIEnv.GetMethodID (class_ref, "getContentType", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContentType), JniHandleOwnership.TransferLocalRef);
			}
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
			global::Org.Jboss.Aerogear.Android.Pipe.IRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.IRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getBody_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetBody_Ljava_lang_Object_Handler ()
		{
			if (cb_getBody_Ljava_lang_Object_ == null)
				cb_getBody_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBody_Ljava_lang_Object_);
			return cb_getBody_Ljava_lang_Object_;
		}

		static IntPtr n_GetBody_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.IRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.IRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetBody (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getBody_Ljava_lang_Object_;
		public unsafe byte[] GetBody (global::Java.Lang.Object p0)
		{
			if (id_getBody_Ljava_lang_Object_ == IntPtr.Zero)
				id_getBody_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getBody", "(Ljava/lang/Object;)[B");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBody_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
