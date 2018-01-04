using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Core {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.jboss.aerogear.android.core']/interface[@name='ConfigurationProvider']"
	[Register ("org/jboss/aerogear/android/core/ConfigurationProvider", "", "Org.Jboss.Aerogear.Android.Core.IConfigurationProviderInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"CFG extends org.jboss.aerogear.android.core.Config<CFG>"})]
	public partial interface IConfigurationProvider : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.core']/interface[@name='ConfigurationProvider']/method[@name='newConfiguration' and count(parameter)=0]"
		[Register ("newConfiguration", "()Lorg/jboss/aerogear/android/core/Config;", "GetNewConfigurationHandler:Org.Jboss.Aerogear.Android.Core.IConfigurationProviderInvoker, ClassLibrary6")]
		global::Java.Lang.Object NewConfiguration ();

	}

	[global::Android.Runtime.Register ("org/jboss/aerogear/android/core/ConfigurationProvider", DoNotGenerateAcw=true)]
	internal class IConfigurationProviderInvoker : global::Java.Lang.Object, IConfigurationProvider {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/jboss/aerogear/android/core/ConfigurationProvider");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IConfigurationProviderInvoker); }
		}

		IntPtr class_ref;

		public static IConfigurationProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConfigurationProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.jboss.aerogear.android.core.ConfigurationProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConfigurationProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_newConfiguration;
#pragma warning disable 0169
		static Delegate GetNewConfigurationHandler ()
		{
			if (cb_newConfiguration == null)
				cb_newConfiguration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NewConfiguration);
			return cb_newConfiguration;
		}

		static IntPtr n_NewConfiguration (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Core.IConfigurationProvider __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Core.IConfigurationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewConfiguration ());
		}
#pragma warning restore 0169

		IntPtr id_newConfiguration;
		public unsafe global::Java.Lang.Object NewConfiguration ()
		{
			if (id_newConfiguration == IntPtr.Zero)
				id_newConfiguration = JNIEnv.GetMethodID (class_ref, "newConfiguration", "()Lorg/jboss/aerogear/android/core/Config;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_newConfiguration), JniHandleOwnership.TransferLocalRef);
		}

	}

}
