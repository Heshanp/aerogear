using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Core {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.jboss.aerogear.android.core']/interface[@name='Config']"
	[Register ("org/jboss/aerogear/android/core/Config", "", "Org.Jboss.Aerogear.Android.Core.IConfigInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"CFG extends org.jboss.aerogear.android.core.Config"})]
	public partial interface IConfig : IJavaObject {

		string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.core']/interface[@name='Config']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Org.Jboss.Aerogear.Android.Core.IConfigInvoker, ClassLibrary6")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.core']/interface[@name='Config']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setName", "(Ljava/lang/String;)Lorg/jboss/aerogear/android/core/Config;", "GetSetName_Ljava_lang_String_Handler:Org.Jboss.Aerogear.Android.Core.IConfigInvoker, ClassLibrary6")]
		global::Java.Lang.Object SetName (string p0);

	}

	[global::Android.Runtime.Register ("org/jboss/aerogear/android/core/Config", DoNotGenerateAcw=true)]
	internal class IConfigInvoker : global::Java.Lang.Object, IConfig {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/jboss/aerogear/android/core/Config");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IConfigInvoker); }
		}

		IntPtr class_ref;

		public static IConfig GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConfig> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.jboss.aerogear.android.core.Config"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConfigInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Core.IConfig __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Core.IConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		IntPtr id_getName;
		public unsafe string Name {
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetName_Ljava_lang_String_Handler ()
		{
			if (cb_setName_Ljava_lang_String_ == null)
				cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetName_Ljava_lang_String_);
			return cb_setName_Ljava_lang_String_;
		}

		static IntPtr n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jboss.Aerogear.Android.Core.IConfig __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Core.IConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetName (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setName_Ljava_lang_String_;
		public unsafe global::Java.Lang.Object SetName (string p0)
		{
			if (id_setName_Ljava_lang_String_ == IntPtr.Zero)
				id_setName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setName", "(Ljava/lang/String;)Lorg/jboss/aerogear/android/core/Config;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
