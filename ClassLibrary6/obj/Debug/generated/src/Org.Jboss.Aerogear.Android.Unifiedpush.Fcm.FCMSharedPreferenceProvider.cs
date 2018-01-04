using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Unifiedpush.Fcm {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.fcm']/class[@name='FCMSharedPreferenceProvider']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/unifiedpush/fcm/FCMSharedPreferenceProvider", DoNotGenerateAcw=true)]
	public partial class FCMSharedPreferenceProvider : global::Java.Lang.Object, global::Org.Jboss.Aerogear.Android.Core.IProvider {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/unifiedpush/fcm/FCMSharedPreferenceProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FCMSharedPreferenceProvider); }
		}

		protected FCMSharedPreferenceProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.fcm']/class[@name='FCMSharedPreferenceProvider']/constructor[@name='FCMSharedPreferenceProvider' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FCMSharedPreferenceProvider ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (FCMSharedPreferenceProvider)) {
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

		static Delegate cb_get_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGet_arrayLjava_lang_Object_Handler ()
		{
			if (cb_get_arrayLjava_lang_Object_ == null)
				cb_get_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_arrayLjava_lang_Object_);
			return cb_get_arrayLjava_lang_Object_;
		}

		static IntPtr n_Get_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native__in)
		{
			global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.FCMSharedPreferenceProvider __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.FCMSharedPreferenceProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] @in = (global::Java.Lang.Object[]) JNIEnv.GetArray (native__in, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (@in));
			if (@in != null)
				JNIEnv.CopyArray (@in, native__in);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.fcm']/class[@name='FCMSharedPreferenceProvider']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("get", "([Ljava/lang/Object;)Landroid/content/SharedPreferences;", "GetGet_arrayLjava_lang_Object_Handler")]
		public virtual unsafe global::Android.Content.ISharedPreferences Get (params global:: Java.Lang.Object[] @in)
		{
			if (id_get_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_get_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "get", "([Ljava/lang/Object;)Landroid/content/SharedPreferences;");
			IntPtr native__in = JNIEnv.NewArray (@in);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__in);

				global::Android.Content.ISharedPreferences __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Content.ISharedPreferences> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Content.ISharedPreferences> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "([Ljava/lang/Object;)Landroid/content/SharedPreferences;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (@in != null) {
					JNIEnv.CopyArray (native__in, @in);
					JNIEnv.DeleteLocalRef (native__in);
				}
			}
		}

		// This method is explicitly implemented as a member of an instantiated Org.Jboss.Aerogear.Android.Core.IProvider
		global::Java.Lang.Object global::Org.Jboss.Aerogear.Android.Core.IProvider.Get (params global:: Java.Lang.Object[] p0)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(Get (p0));
		}

	}
}
