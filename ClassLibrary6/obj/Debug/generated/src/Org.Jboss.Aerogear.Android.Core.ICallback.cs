using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Core {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.jboss.aerogear.android.core']/interface[@name='Callback']"
	[Register ("org/jboss/aerogear/android/core/Callback", "", "Org.Jboss.Aerogear.Android.Core.ICallbackInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface ICallback : global::Java.IO.ISerializable {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.core']/interface[@name='Callback']/method[@name='onFailure' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("onFailure", "(Ljava/lang/Exception;)V", "GetOnFailure_Ljava_lang_Exception_Handler:Org.Jboss.Aerogear.Android.Core.ICallbackInvoker, ClassLibrary6")]
		void OnFailure (global::Java.Lang.Exception p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.core']/interface[@name='Callback']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("onSuccess", "(Ljava/lang/Object;)V", "GetOnSuccess_Ljava_lang_Object_Handler:Org.Jboss.Aerogear.Android.Core.ICallbackInvoker, ClassLibrary6")]
		void OnSuccess (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("org/jboss/aerogear/android/core/Callback", DoNotGenerateAcw=true)]
	internal class ICallbackInvoker : global::Java.Lang.Object, ICallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/jboss/aerogear/android/core/Callback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICallbackInvoker); }
		}

		IntPtr class_ref;

		public static ICallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.jboss.aerogear.android.core.Callback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFailure_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnFailure_Ljava_lang_Exception_Handler ()
		{
			if (cb_onFailure_Ljava_lang_Exception_ == null)
				cb_onFailure_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFailure_Ljava_lang_Exception_);
			return cb_onFailure_Ljava_lang_Exception_;
		}

		static void n_OnFailure_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jboss.Aerogear.Android.Core.ICallback __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Core.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure (p0);
		}
#pragma warning restore 0169

		IntPtr id_onFailure_Ljava_lang_Exception_;
		public unsafe void OnFailure (global::Java.Lang.Exception p0)
		{
			if (id_onFailure_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onFailure_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Ljava/lang/Exception;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailure_Ljava_lang_Exception_, __args);
		}

		static Delegate cb_onSuccess_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Ljava_lang_Object_Handler ()
		{
			if (cb_onSuccess_Ljava_lang_Object_ == null)
				cb_onSuccess_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_Ljava_lang_Object_);
			return cb_onSuccess_Ljava_lang_Object_;
		}

		static void n_OnSuccess_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jboss.Aerogear.Android.Core.ICallback __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Core.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Ljava_lang_Object_;
		public unsafe void OnSuccess (global::Java.Lang.Object p0)
		{
			if (id_onSuccess_Ljava_lang_Object_ == IntPtr.Zero)
				id_onSuccess_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
