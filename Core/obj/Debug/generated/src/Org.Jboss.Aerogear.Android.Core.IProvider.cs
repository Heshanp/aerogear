using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Core {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.jboss.aerogear.android.core']/interface[@name='Provider']"
	[Register ("org/jboss/aerogear/android/core/Provider", "", "Org.Jboss.Aerogear.Android.Core.IProviderInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IProvider : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.core']/interface[@name='Provider']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("get", "([Ljava/lang/Object;)Ljava/lang/Object;", "GetGet_arrayLjava_lang_Object_Handler:Org.Jboss.Aerogear.Android.Core.IProviderInvoker, Core")]
		global::Java.Lang.Object Get (params global:: Java.Lang.Object[] p0);

	}

	[global::Android.Runtime.Register ("org/jboss/aerogear/android/core/Provider", DoNotGenerateAcw=true)]
	internal class IProviderInvoker : global::Java.Lang.Object, IProvider {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/jboss/aerogear/android/core/Provider");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IProviderInvoker); }
		}

		IntPtr class_ref;

		public static IProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.jboss.aerogear.android.core.Provider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_get_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGet_arrayLjava_lang_Object_Handler ()
		{
			if (cb_get_arrayLjava_lang_Object_ == null)
				cb_get_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_arrayLjava_lang_Object_);
			return cb_get_arrayLjava_lang_Object_;
		}

		static IntPtr n_Get_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jboss.Aerogear.Android.Core.IProvider __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Core.IProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_get_arrayLjava_lang_Object_;
		public unsafe global::Java.Lang.Object Get (params global:: Java.Lang.Object[] p0)
		{
			if (id_get_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_get_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "get", "([Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}

}
