using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Unifiedpush {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush']/class[@name='PushConfiguration']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/unifiedpush/PushConfiguration", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"CONFIGURATION extends org.jboss.aerogear.android.unifiedpush.PushConfiguration"})]
	public abstract partial class PushConfiguration : global::Java.Lang.Object, global::Org.Jboss.Aerogear.Android.Core.IConfig {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/unifiedpush/PushConfiguration", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PushConfiguration); }
		}

		protected PushConfiguration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush']/class[@name='PushConfiguration']/constructor[@name='PushConfiguration' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PushConfiguration ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PushConfiguration)) {
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
			global::Org.Jboss.Aerogear.Android.Unifiedpush.PushConfiguration __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Unifiedpush.PushConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush']/class[@name='PushConfiguration']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOnAuthenticationCreatedListeners;
#pragma warning disable 0169
		static Delegate GetGetOnAuthenticationCreatedListenersHandler ()
		{
			if (cb_getOnAuthenticationCreatedListeners == null)
				cb_getOnAuthenticationCreatedListeners = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnAuthenticationCreatedListeners);
			return cb_getOnAuthenticationCreatedListeners;
		}

		static IntPtr n_GetOnAuthenticationCreatedListeners (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Unifiedpush.PushConfiguration __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Unifiedpush.PushConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<global::Org.Jboss.Aerogear.Android.Unifiedpush.IOnPushRegistrarCreatedListener>.ToLocalJniHandle (__this.OnAuthenticationCreatedListeners);
		}
#pragma warning restore 0169

		static IntPtr id_getOnAuthenticationCreatedListeners;
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Org.Jboss.Aerogear.Android.Unifiedpush.IOnPushRegistrarCreatedListener> OnAuthenticationCreatedListeners {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush']/class[@name='PushConfiguration']/method[@name='getOnAuthenticationCreatedListeners' and count(parameter)=0]"
			[Register ("getOnAuthenticationCreatedListeners", "()Ljava/util/Collection;", "GetGetOnAuthenticationCreatedListenersHandler")]
			get {
				if (id_getOnAuthenticationCreatedListeners == IntPtr.Zero)
					id_getOnAuthenticationCreatedListeners = JNIEnv.GetMethodID (class_ref, "getOnAuthenticationCreatedListeners", "()Ljava/util/Collection;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaCollection<global::Org.Jboss.Aerogear.Android.Unifiedpush.IOnPushRegistrarCreatedListener>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnAuthenticationCreatedListeners), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaCollection<global::Org.Jboss.Aerogear.Android.Unifiedpush.IOnPushRegistrarCreatedListener>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOnAuthenticationCreatedListeners", "()Ljava/util/Collection;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addOnPushRegistrarCreatedListener_Lorg_jboss_aerogear_android_unifiedpush_OnPushRegistrarCreatedListener_;
#pragma warning disable 0169
		static Delegate GetAddOnPushRegistrarCreatedListener_Lorg_jboss_aerogear_android_unifiedpush_OnPushRegistrarCreatedListener_Handler ()
		{
			if (cb_addOnPushRegistrarCreatedListener_Lorg_jboss_aerogear_android_unifiedpush_OnPushRegistrarCreatedListener_ == null)
				cb_addOnPushRegistrarCreatedListener_Lorg_jboss_aerogear_android_unifiedpush_OnPushRegistrarCreatedListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddOnPushRegistrarCreatedListener_Lorg_jboss_aerogear_android_unifiedpush_OnPushRegistrarCreatedListener_);
			return cb_addOnPushRegistrarCreatedListener_Lorg_jboss_aerogear_android_unifiedpush_OnPushRegistrarCreatedListener_;
		}

		static IntPtr n_AddOnPushRegistrarCreatedListener_Lorg_jboss_aerogear_android_unifiedpush_OnPushRegistrarCreatedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Org.Jboss.Aerogear.Android.Unifiedpush.PushConfiguration __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Unifiedpush.PushConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jboss.Aerogear.Android.Unifiedpush.IOnPushRegistrarCreatedListener listener = (global::Org.Jboss.Aerogear.Android.Unifiedpush.IOnPushRegistrarCreatedListener)global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Unifiedpush.IOnPushRegistrarCreatedListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddOnPushRegistrarCreatedListener (listener));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addOnPushRegistrarCreatedListener_Lorg_jboss_aerogear_android_unifiedpush_OnPushRegistrarCreatedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush']/class[@name='PushConfiguration']/method[@name='addOnPushRegistrarCreatedListener' and count(parameter)=1 and parameter[1][@type='org.jboss.aerogear.android.unifiedpush.OnPushRegistrarCreatedListener']]"
		[Register ("addOnPushRegistrarCreatedListener", "(Lorg/jboss/aerogear/android/unifiedpush/OnPushRegistrarCreatedListener;)Lorg/jboss/aerogear/android/unifiedpush/PushConfiguration;", "GetAddOnPushRegistrarCreatedListener_Lorg_jboss_aerogear_android_unifiedpush_OnPushRegistrarCreatedListener_Handler")]
		public virtual unsafe global::Java.Lang.Object AddOnPushRegistrarCreatedListener (global::Org.Jboss.Aerogear.Android.Unifiedpush.IOnPushRegistrarCreatedListener listener)
		{
			if (id_addOnPushRegistrarCreatedListener_Lorg_jboss_aerogear_android_unifiedpush_OnPushRegistrarCreatedListener_ == IntPtr.Zero)
				id_addOnPushRegistrarCreatedListener_Lorg_jboss_aerogear_android_unifiedpush_OnPushRegistrarCreatedListener_ = JNIEnv.GetMethodID (class_ref, "addOnPushRegistrarCreatedListener", "(Lorg/jboss/aerogear/android/unifiedpush/OnPushRegistrarCreatedListener;)Lorg/jboss/aerogear/android/unifiedpush/PushConfiguration;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (listener);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addOnPushRegistrarCreatedListener_Lorg_jboss_aerogear_android_unifiedpush_OnPushRegistrarCreatedListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addOnPushRegistrarCreatedListener", "(Lorg/jboss/aerogear/android/unifiedpush/OnPushRegistrarCreatedListener;)Lorg/jboss/aerogear/android/unifiedpush/PushConfiguration;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_asRegistrar;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush']/class[@name='PushConfiguration']/method[@name='asRegistrar' and count(parameter)=0]"
		[Register ("asRegistrar", "()Lorg/jboss/aerogear/android/unifiedpush/PushRegistrar;", "")]
		public unsafe global::Org.Jboss.Aerogear.Android.Unifiedpush.IPushRegistrar AsRegistrar ()
		{
			if (id_asRegistrar == IntPtr.Zero)
				id_asRegistrar = JNIEnv.GetMethodID (class_ref, "asRegistrar", "()Lorg/jboss/aerogear/android/unifiedpush/PushRegistrar;");
			try {
				return global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Unifiedpush.IPushRegistrar> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asRegistrar), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_buildRegistrar;
#pragma warning disable 0169
		static Delegate GetBuildRegistrarHandler ()
		{
			if (cb_buildRegistrar == null)
				cb_buildRegistrar = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_BuildRegistrar);
			return cb_buildRegistrar;
		}

		static IntPtr n_BuildRegistrar (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Unifiedpush.PushConfiguration __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Unifiedpush.PushConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BuildRegistrar ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush']/class[@name='PushConfiguration']/method[@name='buildRegistrar' and count(parameter)=0]"
		[Register ("buildRegistrar", "()Lorg/jboss/aerogear/android/unifiedpush/PushRegistrar;", "GetBuildRegistrarHandler")]
		protected abstract global::Org.Jboss.Aerogear.Android.Unifiedpush.IPushRegistrar BuildRegistrar ();

		static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetName_Ljava_lang_String_Handler ()
		{
			if (cb_setName_Ljava_lang_String_ == null)
				cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetName_Ljava_lang_String_);
			return cb_setName_Ljava_lang_String_;
		}

		static IntPtr n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Org.Jboss.Aerogear.Android.Unifiedpush.PushConfiguration __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Unifiedpush.PushConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetName (name));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush']/class[@name='PushConfiguration']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setName", "(Ljava/lang/String;)Lorg/jboss/aerogear/android/unifiedpush/PushConfiguration;", "GetSetName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Object SetName (string name)
		{
			if (id_setName_Ljava_lang_String_ == IntPtr.Zero)
				id_setName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setName", "(Ljava/lang/String;)Lorg/jboss/aerogear/android/unifiedpush/PushConfiguration;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setName", "(Ljava/lang/String;)Lorg/jboss/aerogear/android/unifiedpush/PushConfiguration;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_setOnPushRegistrarCreatedListeners_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetSetOnPushRegistrarCreatedListeners_Ljava_util_Collection_Handler ()
		{
			if (cb_setOnPushRegistrarCreatedListeners_Ljava_util_Collection_ == null)
				cb_setOnPushRegistrarCreatedListeners_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOnPushRegistrarCreatedListeners_Ljava_util_Collection_);
			return cb_setOnPushRegistrarCreatedListeners_Ljava_util_Collection_;
		}

		static IntPtr n_SetOnPushRegistrarCreatedListeners_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listeners)
		{
			global::Org.Jboss.Aerogear.Android.Unifiedpush.PushConfiguration __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Unifiedpush.PushConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listeners = global::Android.Runtime.JavaCollection<global::Org.Jboss.Aerogear.Android.Unifiedpush.IOnPushRegistrarCreatedListener>.FromJniHandle (native_listeners, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOnPushRegistrarCreatedListeners (listeners));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setOnPushRegistrarCreatedListeners_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush']/class[@name='PushConfiguration']/method[@name='setOnPushRegistrarCreatedListeners' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;org.jboss.aerogear.android.unifiedpush.OnPushRegistrarCreatedListener&gt;']]"
		[Register ("setOnPushRegistrarCreatedListeners", "(Ljava/util/Collection;)Lorg/jboss/aerogear/android/unifiedpush/PushConfiguration;", "GetSetOnPushRegistrarCreatedListeners_Ljava_util_Collection_Handler")]
		public virtual unsafe global::Java.Lang.Object SetOnPushRegistrarCreatedListeners (global::System.Collections.Generic.ICollection<global::Org.Jboss.Aerogear.Android.Unifiedpush.IOnPushRegistrarCreatedListener> listeners)
		{
			if (id_setOnPushRegistrarCreatedListeners_Ljava_util_Collection_ == IntPtr.Zero)
				id_setOnPushRegistrarCreatedListeners_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "setOnPushRegistrarCreatedListeners", "(Ljava/util/Collection;)Lorg/jboss/aerogear/android/unifiedpush/PushConfiguration;");
			IntPtr native_listeners = global::Android.Runtime.JavaCollection<global::Org.Jboss.Aerogear.Android.Unifiedpush.IOnPushRegistrarCreatedListener>.ToLocalJniHandle (listeners);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_listeners);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setOnPushRegistrarCreatedListeners_Ljava_util_Collection_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnPushRegistrarCreatedListeners", "(Ljava/util/Collection;)Lorg/jboss/aerogear/android/unifiedpush/PushConfiguration;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_listeners);
			}
		}

	}

	[global::Android.Runtime.Register ("org/jboss/aerogear/android/unifiedpush/PushConfiguration", DoNotGenerateAcw=true)]
	internal partial class PushConfigurationInvoker : PushConfiguration, global::Org.Jboss.Aerogear.Android.Core.IConfig {

		public PushConfigurationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (PushConfigurationInvoker); }
		}

		static IntPtr id_buildRegistrar;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush']/class[@name='PushConfiguration']/method[@name='buildRegistrar' and count(parameter)=0]"
		[Register ("buildRegistrar", "()Lorg/jboss/aerogear/android/unifiedpush/PushRegistrar;", "GetBuildRegistrarHandler")]
		protected override unsafe global::Org.Jboss.Aerogear.Android.Unifiedpush.IPushRegistrar BuildRegistrar ()
		{
			if (id_buildRegistrar == IntPtr.Zero)
				id_buildRegistrar = JNIEnv.GetMethodID (class_ref, "buildRegistrar", "()Lorg/jboss/aerogear/android/unifiedpush/PushRegistrar;");
			try {
				return global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Unifiedpush.IPushRegistrar> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_buildRegistrar), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
