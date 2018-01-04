using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Unifiedpush {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush']/class[@name='RegistrarManager']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/unifiedpush/RegistrarManager", DoNotGenerateAcw=true)]
	public partial class RegistrarManager : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/unifiedpush/RegistrarManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RegistrarManager); }
		}

		protected RegistrarManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush']/class[@name='RegistrarManager']/constructor[@name='RegistrarManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RegistrarManager ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (RegistrarManager)) {
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

		static IntPtr id_config_Ljava_lang_String_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush']/class[@name='RegistrarManager']/method[@name='config' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class&lt;CFG&gt;']]"
		[Register ("config", "(Ljava/lang/String;Ljava/lang/Class;)Lorg/jboss/aerogear/android/unifiedpush/PushConfiguration;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"CFG extends org.jboss.aerogear.android.unifiedpush.PushConfiguration<CFG>"})]
		public static unsafe global::Java.Lang.Object Config (string name, global::Java.Lang.Class pushConfigurationClass)
		{
			if (id_config_Ljava_lang_String_Ljava_lang_Class_ == IntPtr.Zero)
				id_config_Ljava_lang_String_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "config", "(Ljava/lang/String;Ljava/lang/Class;)Lorg/jboss/aerogear/android/unifiedpush/PushConfiguration;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_name);
				__args [1] = new JValue (pushConfigurationClass);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_config_Ljava_lang_String_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_getRegistrar_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush']/class[@name='RegistrarManager']/method[@name='getRegistrar' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getRegistrar", "(Ljava/lang/String;)Lorg/jboss/aerogear/android/unifiedpush/PushRegistrar;", "")]
		public static unsafe global::Org.Jboss.Aerogear.Android.Unifiedpush.IPushRegistrar GetRegistrar (string name)
		{
			if (id_getRegistrar_Ljava_lang_String_ == IntPtr.Zero)
				id_getRegistrar_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getRegistrar", "(Ljava/lang/String;)Lorg/jboss/aerogear/android/unifiedpush/PushRegistrar;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Org.Jboss.Aerogear.Android.Unifiedpush.IPushRegistrar __ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Unifiedpush.IPushRegistrar> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getRegistrar_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_notifyHandlers_Landroid_content_Context_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush']/class[@name='RegistrarManager']/method[@name='notifyHandlers' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("notifyHandlers", "(Landroid/content/Context;Landroid/os/Bundle;)V", "")]
		protected static unsafe void NotifyHandlers (global::Android.Content.Context context, global::Android.OS.Bundle message)
		{
			if (id_notifyHandlers_Landroid_content_Context_Landroid_os_Bundle_ == IntPtr.Zero)
				id_notifyHandlers_Landroid_content_Context_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "notifyHandlers", "(Landroid/content/Context;Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (message);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_notifyHandlers_Landroid_content_Context_Landroid_os_Bundle_, __args);
			} finally {
			}
		}

		static IntPtr id_notifyHandlers_Landroid_content_Context_Landroid_os_Bundle_Lorg_jboss_aerogear_android_unifiedpush_MessageHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush']/class[@name='RegistrarManager']/method[@name='notifyHandlers' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='org.jboss.aerogear.android.unifiedpush.MessageHandler']]"
		[Register ("notifyHandlers", "(Landroid/content/Context;Landroid/os/Bundle;Lorg/jboss/aerogear/android/unifiedpush/MessageHandler;)V", "")]
		public static unsafe void NotifyHandlers (global::Android.Content.Context context, global::Android.OS.Bundle message, global::Org.Jboss.Aerogear.Android.Unifiedpush.IMessageHandler defaultHandler)
		{
			if (id_notifyHandlers_Landroid_content_Context_Landroid_os_Bundle_Lorg_jboss_aerogear_android_unifiedpush_MessageHandler_ == IntPtr.Zero)
				id_notifyHandlers_Landroid_content_Context_Landroid_os_Bundle_Lorg_jboss_aerogear_android_unifiedpush_MessageHandler_ = JNIEnv.GetStaticMethodID (class_ref, "notifyHandlers", "(Landroid/content/Context;Landroid/os/Bundle;Lorg/jboss/aerogear/android/unifiedpush/MessageHandler;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (context);
				__args [1] = new JValue (message);
				__args [2] = new JValue (defaultHandler);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_notifyHandlers_Landroid_content_Context_Landroid_os_Bundle_Lorg_jboss_aerogear_android_unifiedpush_MessageHandler_, __args);
			} finally {
			}
		}

		static IntPtr id_registerBackgroundThreadHandler_Lorg_jboss_aerogear_android_unifiedpush_MessageHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush']/class[@name='RegistrarManager']/method[@name='registerBackgroundThreadHandler' and count(parameter)=1 and parameter[1][@type='org.jboss.aerogear.android.unifiedpush.MessageHandler']]"
		[Register ("registerBackgroundThreadHandler", "(Lorg/jboss/aerogear/android/unifiedpush/MessageHandler;)V", "")]
		public static unsafe void RegisterBackgroundThreadHandler (global::Org.Jboss.Aerogear.Android.Unifiedpush.IMessageHandler handler)
		{
			if (id_registerBackgroundThreadHandler_Lorg_jboss_aerogear_android_unifiedpush_MessageHandler_ == IntPtr.Zero)
				id_registerBackgroundThreadHandler_Lorg_jboss_aerogear_android_unifiedpush_MessageHandler_ = JNIEnv.GetStaticMethodID (class_ref, "registerBackgroundThreadHandler", "(Lorg/jboss/aerogear/android/unifiedpush/MessageHandler;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (handler);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_registerBackgroundThreadHandler_Lorg_jboss_aerogear_android_unifiedpush_MessageHandler_, __args);
			} finally {
			}
		}

		static IntPtr id_registerConfigurationProvider_Ljava_lang_Class_Lorg_jboss_aerogear_android_core_ConfigurationProvider_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush']/class[@name='RegistrarManager']/method[@name='registerConfigurationProvider' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;CFG&gt;'] and parameter[2][@type='org.jboss.aerogear.android.core.ConfigurationProvider&lt;CFG&gt;']]"
		[Register ("registerConfigurationProvider", "(Ljava/lang/Class;Lorg/jboss/aerogear/android/core/ConfigurationProvider;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"CFG extends org.jboss.aerogear.android.unifiedpush.PushConfiguration<CFG>"})]
		public static unsafe void RegisterConfigurationProvider (global::Java.Lang.Class configurationClass, global::Org.Jboss.Aerogear.Android.Core.IConfigurationProvider provider)
		{
			if (id_registerConfigurationProvider_Ljava_lang_Class_Lorg_jboss_aerogear_android_core_ConfigurationProvider_ == IntPtr.Zero)
				id_registerConfigurationProvider_Ljava_lang_Class_Lorg_jboss_aerogear_android_core_ConfigurationProvider_ = JNIEnv.GetStaticMethodID (class_ref, "registerConfigurationProvider", "(Ljava/lang/Class;Lorg/jboss/aerogear/android/core/ConfigurationProvider;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (configurationClass);
				__args [1] = new JValue (provider);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_registerConfigurationProvider_Ljava_lang_Class_Lorg_jboss_aerogear_android_core_ConfigurationProvider_, __args);
			} finally {
			}
		}

		static IntPtr id_registerMainThreadHandler_Lorg_jboss_aerogear_android_unifiedpush_MessageHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush']/class[@name='RegistrarManager']/method[@name='registerMainThreadHandler' and count(parameter)=1 and parameter[1][@type='org.jboss.aerogear.android.unifiedpush.MessageHandler']]"
		[Register ("registerMainThreadHandler", "(Lorg/jboss/aerogear/android/unifiedpush/MessageHandler;)V", "")]
		public static unsafe void RegisterMainThreadHandler (global::Org.Jboss.Aerogear.Android.Unifiedpush.IMessageHandler handler)
		{
			if (id_registerMainThreadHandler_Lorg_jboss_aerogear_android_unifiedpush_MessageHandler_ == IntPtr.Zero)
				id_registerMainThreadHandler_Lorg_jboss_aerogear_android_unifiedpush_MessageHandler_ = JNIEnv.GetStaticMethodID (class_ref, "registerMainThreadHandler", "(Lorg/jboss/aerogear/android/unifiedpush/MessageHandler;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (handler);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_registerMainThreadHandler_Lorg_jboss_aerogear_android_unifiedpush_MessageHandler_, __args);
			} finally {
			}
		}

		static IntPtr id_unregisterBackgroundThreadHandler_Lorg_jboss_aerogear_android_unifiedpush_MessageHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush']/class[@name='RegistrarManager']/method[@name='unregisterBackgroundThreadHandler' and count(parameter)=1 and parameter[1][@type='org.jboss.aerogear.android.unifiedpush.MessageHandler']]"
		[Register ("unregisterBackgroundThreadHandler", "(Lorg/jboss/aerogear/android/unifiedpush/MessageHandler;)V", "")]
		public static unsafe void UnregisterBackgroundThreadHandler (global::Org.Jboss.Aerogear.Android.Unifiedpush.IMessageHandler handler)
		{
			if (id_unregisterBackgroundThreadHandler_Lorg_jboss_aerogear_android_unifiedpush_MessageHandler_ == IntPtr.Zero)
				id_unregisterBackgroundThreadHandler_Lorg_jboss_aerogear_android_unifiedpush_MessageHandler_ = JNIEnv.GetStaticMethodID (class_ref, "unregisterBackgroundThreadHandler", "(Lorg/jboss/aerogear/android/unifiedpush/MessageHandler;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (handler);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_unregisterBackgroundThreadHandler_Lorg_jboss_aerogear_android_unifiedpush_MessageHandler_, __args);
			} finally {
			}
		}

		static IntPtr id_unregisterMainThreadHandler_Lorg_jboss_aerogear_android_unifiedpush_MessageHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush']/class[@name='RegistrarManager']/method[@name='unregisterMainThreadHandler' and count(parameter)=1 and parameter[1][@type='org.jboss.aerogear.android.unifiedpush.MessageHandler']]"
		[Register ("unregisterMainThreadHandler", "(Lorg/jboss/aerogear/android/unifiedpush/MessageHandler;)V", "")]
		public static unsafe void UnregisterMainThreadHandler (global::Org.Jboss.Aerogear.Android.Unifiedpush.IMessageHandler handler)
		{
			if (id_unregisterMainThreadHandler_Lorg_jboss_aerogear_android_unifiedpush_MessageHandler_ == IntPtr.Zero)
				id_unregisterMainThreadHandler_Lorg_jboss_aerogear_android_unifiedpush_MessageHandler_ = JNIEnv.GetStaticMethodID (class_ref, "unregisterMainThreadHandler", "(Lorg/jboss/aerogear/android/unifiedpush/MessageHandler;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (handler);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_unregisterMainThreadHandler_Lorg_jboss_aerogear_android_unifiedpush_MessageHandler_, __args);
			} finally {
			}
		}

	}
}
