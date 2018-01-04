using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Pipe {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.pipe']/class[@name='PipeConfiguration']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/PipeConfiguration", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"CONFIGURATION extends org.jboss.aerogear.android.pipe.PipeConfiguration<CONFIGURATION>"})]
	public abstract partial class PipeConfiguration : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/pipe/PipeConfiguration", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PipeConfiguration); }
		}

		protected PipeConfiguration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.pipe']/class[@name='PipeConfiguration']/constructor[@name='PipeConfiguration' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PipeConfiguration ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PipeConfiguration)) {
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

		static Delegate cb_getModules;
#pragma warning disable 0169
		static Delegate GetGetModulesHandler ()
		{
			if (cb_getModules == null)
				cb_getModules = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetModules);
			return cb_getModules;
		}

		static IntPtr n_GetModules (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.PipeConfiguration __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.PipeConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Jboss.Aerogear.Android.Pipe.Module.IPipeModule>.ToLocalJniHandle (__this.Modules);
		}
#pragma warning restore 0169

		public abstract global::System.Collections.Generic.IList<global::Org.Jboss.Aerogear.Android.Pipe.Module.IPipeModule> Modules {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe']/class[@name='PipeConfiguration']/method[@name='getModules' and count(parameter)=0]"
			[Register ("getModules", "()Ljava/util/List;", "GetGetModulesHandler")] get;
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
			global::Org.Jboss.Aerogear.Android.Pipe.PipeConfiguration __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.PipeConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe']/class[@name='PipeConfiguration']/method[@name='getName' and count(parameter)=0]"
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

		static Delegate cb_module_Lorg_jboss_aerogear_android_pipe_module_PipeModule_;
#pragma warning disable 0169
		static Delegate GetModule_Lorg_jboss_aerogear_android_pipe_module_PipeModule_Handler ()
		{
			if (cb_module_Lorg_jboss_aerogear_android_pipe_module_PipeModule_ == null)
				cb_module_Lorg_jboss_aerogear_android_pipe_module_PipeModule_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Module_Lorg_jboss_aerogear_android_pipe_module_PipeModule_);
			return cb_module_Lorg_jboss_aerogear_android_pipe_module_PipeModule_;
		}

		static IntPtr n_Module_Lorg_jboss_aerogear_android_pipe_module_PipeModule_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.PipeConfiguration __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.PipeConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jboss.Aerogear.Android.Pipe.Module.IPipeModule p0 = (global::Org.Jboss.Aerogear.Android.Pipe.Module.IPipeModule)global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Module.IPipeModule> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Module (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe']/class[@name='PipeConfiguration']/method[@name='module' and count(parameter)=1 and parameter[1][@type='org.jboss.aerogear.android.pipe.module.PipeModule']]"
		[Register ("module", "(Lorg/jboss/aerogear/android/pipe/module/PipeModule;)Lorg/jboss/aerogear/android/pipe/PipeConfiguration;", "GetModule_Lorg_jboss_aerogear_android_pipe_module_PipeModule_Handler")]
		public abstract global::Org.Jboss.Aerogear.Android.Pipe.PipeConfiguration Module (global::Org.Jboss.Aerogear.Android.Pipe.Module.IPipeModule p0);

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
			global::Org.Jboss.Aerogear.Android.Pipe.PipeConfiguration __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.PipeConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetName (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe']/class[@name='PipeConfiguration']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setName", "(Ljava/lang/String;)Lorg/jboss/aerogear/android/pipe/PipeConfiguration;", "GetSetName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Object SetName (string p0)
		{
			if (id_setName_Ljava_lang_String_ == IntPtr.Zero)
				id_setName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setName", "(Ljava/lang/String;)Lorg/jboss/aerogear/android/pipe/PipeConfiguration;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setName", "(Ljava/lang/String;)Lorg/jboss/aerogear/android/pipe/PipeConfiguration;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withUrl_Ljava_net_URL_;
#pragma warning disable 0169
		static Delegate GetWithUrl_Ljava_net_URL_Handler ()
		{
			if (cb_withUrl_Ljava_net_URL_ == null)
				cb_withUrl_Ljava_net_URL_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithUrl_Ljava_net_URL_);
			return cb_withUrl_Ljava_net_URL_;
		}

		static IntPtr n_WithUrl_Ljava_net_URL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.PipeConfiguration __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.PipeConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.URL p0 = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithUrl (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe']/class[@name='PipeConfiguration']/method[@name='withUrl' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
		[Register ("withUrl", "(Ljava/net/URL;)Lorg/jboss/aerogear/android/pipe/PipeConfiguration;", "GetWithUrl_Ljava_net_URL_Handler")]
		public abstract global::Org.Jboss.Aerogear.Android.Pipe.PipeConfiguration WithUrl (global::Java.Net.URL p0);

	}

	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/PipeConfiguration", DoNotGenerateAcw=true)]
	internal partial class PipeConfigurationInvoker : PipeConfiguration {

		public PipeConfigurationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (PipeConfigurationInvoker); }
		}

		static IntPtr id_getModules;
		public override unsafe global::System.Collections.Generic.IList<global::Org.Jboss.Aerogear.Android.Pipe.Module.IPipeModule> Modules {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe']/class[@name='PipeConfiguration']/method[@name='getModules' and count(parameter)=0]"
			[Register ("getModules", "()Ljava/util/List;", "GetGetModulesHandler")]
			get {
				if (id_getModules == IntPtr.Zero)
					id_getModules = JNIEnv.GetMethodID (class_ref, "getModules", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<global::Org.Jboss.Aerogear.Android.Pipe.Module.IPipeModule>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getModules), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_module_Lorg_jboss_aerogear_android_pipe_module_PipeModule_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe']/class[@name='PipeConfiguration']/method[@name='module' and count(parameter)=1 and parameter[1][@type='org.jboss.aerogear.android.pipe.module.PipeModule']]"
		[Register ("module", "(Lorg/jboss/aerogear/android/pipe/module/PipeModule;)Lorg/jboss/aerogear/android/pipe/PipeConfiguration;", "GetModule_Lorg_jboss_aerogear_android_pipe_module_PipeModule_Handler")]
		public override unsafe global::Org.Jboss.Aerogear.Android.Pipe.PipeConfiguration Module (global::Org.Jboss.Aerogear.Android.Pipe.Module.IPipeModule p0)
		{
			if (id_module_Lorg_jboss_aerogear_android_pipe_module_PipeModule_ == IntPtr.Zero)
				id_module_Lorg_jboss_aerogear_android_pipe_module_PipeModule_ = JNIEnv.GetMethodID (class_ref, "module", "(Lorg/jboss/aerogear/android/pipe/module/PipeModule;)Lorg/jboss/aerogear/android/pipe/PipeConfiguration;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Jboss.Aerogear.Android.Pipe.PipeConfiguration __ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.PipeConfiguration> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_module_Lorg_jboss_aerogear_android_pipe_module_PipeModule_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_withUrl_Ljava_net_URL_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe']/class[@name='PipeConfiguration']/method[@name='withUrl' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
		[Register ("withUrl", "(Ljava/net/URL;)Lorg/jboss/aerogear/android/pipe/PipeConfiguration;", "GetWithUrl_Ljava_net_URL_Handler")]
		public override unsafe global::Org.Jboss.Aerogear.Android.Pipe.PipeConfiguration WithUrl (global::Java.Net.URL p0)
		{
			if (id_withUrl_Ljava_net_URL_ == IntPtr.Zero)
				id_withUrl_Ljava_net_URL_ = JNIEnv.GetMethodID (class_ref, "withUrl", "(Ljava/net/URL;)Lorg/jboss/aerogear/android/pipe/PipeConfiguration;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Jboss.Aerogear.Android.Pipe.PipeConfiguration __ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.PipeConfiguration> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withUrl_Ljava_net_URL_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

}
