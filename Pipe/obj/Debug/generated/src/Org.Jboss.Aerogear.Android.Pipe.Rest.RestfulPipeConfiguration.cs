using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Pipe.Rest {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest']/class[@name='RestfulPipeConfiguration']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/rest/RestfulPipeConfiguration", DoNotGenerateAcw=true)]
	public partial class RestfulPipeConfiguration : global::Org.Jboss.Aerogear.Android.Pipe.PipeConfiguration {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/pipe/rest/RestfulPipeConfiguration", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RestfulPipeConfiguration); }
		}

		protected RestfulPipeConfiguration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest']/class[@name='RestfulPipeConfiguration']/constructor[@name='RestfulPipeConfiguration' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RestfulPipeConfiguration ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (RestfulPipeConfiguration)) {
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
			global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Jboss.Aerogear.Android.Pipe.Module.IPipeModule>.ToLocalJniHandle (__this.Modules);
		}
#pragma warning restore 0169

		static IntPtr id_getModules;
		public override unsafe global::System.Collections.Generic.IList<global::Org.Jboss.Aerogear.Android.Pipe.Module.IPipeModule> Modules {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest']/class[@name='RestfulPipeConfiguration']/method[@name='getModules' and count(parameter)=0]"
			[Register ("getModules", "()Ljava/util/List;", "GetGetModulesHandler")]
			get {
				if (id_getModules == IntPtr.Zero)
					id_getModules = JNIEnv.GetMethodID (class_ref, "getModules", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Org.Jboss.Aerogear.Android.Pipe.Module.IPipeModule>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getModules), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Org.Jboss.Aerogear.Android.Pipe.Module.IPipeModule>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getModules", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPageConfig;
#pragma warning disable 0169
		static Delegate GetGetPageConfigHandler ()
		{
			if (cb_getPageConfig == null)
				cb_getPageConfig = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPageConfig);
			return cb_getPageConfig;
		}

		static IntPtr n_GetPageConfig (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PageConfig);
		}
#pragma warning restore 0169

		static IntPtr id_getPageConfig;
		public virtual unsafe global::Org.Jboss.Aerogear.Android.Pipe.Paging.PageConfig PageConfig {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest']/class[@name='RestfulPipeConfiguration']/method[@name='getPageConfig' and count(parameter)=0]"
			[Register ("getPageConfig", "()Lorg/jboss/aerogear/android/pipe/paging/PageConfig;", "GetGetPageConfigHandler")]
			get {
				if (id_getPageConfig == IntPtr.Zero)
					id_getPageConfig = JNIEnv.GetMethodID (class_ref, "getPageConfig", "()Lorg/jboss/aerogear/android/pipe/paging/PageConfig;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Paging.PageConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPageConfig), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Paging.PageConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPageConfig", "()Lorg/jboss/aerogear/android/pipe/paging/PageConfig;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRequestBuilder;
#pragma warning disable 0169
		static Delegate GetGetRequestBuilderHandler ()
		{
			if (cb_getRequestBuilder == null)
				cb_getRequestBuilder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestBuilder);
			return cb_getRequestBuilder;
		}

		static IntPtr n_GetRequestBuilder (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RequestBuilder);
		}
#pragma warning restore 0169

		static IntPtr id_getRequestBuilder;
		public virtual unsafe global::Org.Jboss.Aerogear.Android.Pipe.IRequestBuilder RequestBuilder {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest']/class[@name='RestfulPipeConfiguration']/method[@name='getRequestBuilder' and count(parameter)=0]"
			[Register ("getRequestBuilder", "()Lorg/jboss/aerogear/android/pipe/RequestBuilder;", "GetGetRequestBuilderHandler")]
			get {
				if (id_getRequestBuilder == IntPtr.Zero)
					id_getRequestBuilder = JNIEnv.GetMethodID (class_ref, "getRequestBuilder", "()Lorg/jboss/aerogear/android/pipe/RequestBuilder;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.IRequestBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequestBuilder), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.IRequestBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestBuilder", "()Lorg/jboss/aerogear/android/pipe/RequestBuilder;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getResponseParser;
#pragma warning disable 0169
		static Delegate GetGetResponseParserHandler ()
		{
			if (cb_getResponseParser == null)
				cb_getResponseParser = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponseParser);
			return cb_getResponseParser;
		}

		static IntPtr n_GetResponseParser (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ResponseParser);
		}
#pragma warning restore 0169

		static IntPtr id_getResponseParser;
		public virtual unsafe global::Org.Jboss.Aerogear.Android.Pipe.IResponseParser ResponseParser {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest']/class[@name='RestfulPipeConfiguration']/method[@name='getResponseParser' and count(parameter)=0]"
			[Register ("getResponseParser", "()Lorg/jboss/aerogear/android/pipe/ResponseParser;", "GetGetResponseParserHandler")]
			get {
				if (id_getResponseParser == IntPtr.Zero)
					id_getResponseParser = JNIEnv.GetMethodID (class_ref, "getResponseParser", "()Lorg/jboss/aerogear/android/pipe/ResponseParser;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.IResponseParser> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponseParser), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.IResponseParser> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponseParser", "()Lorg/jboss/aerogear/android/pipe/ResponseParser;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTimeout;
#pragma warning disable 0169
		static Delegate GetGetTimeoutHandler ()
		{
			if (cb_getTimeout == null)
				cb_getTimeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTimeout);
			return cb_getTimeout;
		}

		static IntPtr n_GetTimeout (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Timeout);
		}
#pragma warning restore 0169

		static IntPtr id_getTimeout;
		public virtual unsafe global::Java.Lang.Integer Timeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest']/class[@name='RestfulPipeConfiguration']/method[@name='getTimeout' and count(parameter)=0]"
			[Register ("getTimeout", "()Ljava/lang/Integer;", "GetGetTimeoutHandler")]
			get {
				if (id_getTimeout == IntPtr.Zero)
					id_getTimeout = JNIEnv.GetMethodID (class_ref, "getTimeout", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTimeout), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimeout", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUrl;
#pragma warning disable 0169
		static Delegate GetGetUrlHandler ()
		{
			if (cb_getUrl == null)
				cb_getUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUrl);
			return cb_getUrl;
		}

		static IntPtr n_GetUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Url);
		}
#pragma warning restore 0169

		static IntPtr id_getUrl;
		public virtual unsafe global::Java.Net.URL Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest']/class[@name='RestfulPipeConfiguration']/method[@name='getUrl' and count(parameter)=0]"
			[Register ("getUrl", "()Ljava/net/URL;", "GetGetUrlHandler")]
			get {
				if (id_getUrl == IntPtr.Zero)
					id_getUrl = JNIEnv.GetMethodID (class_ref, "getUrl", "()Ljava/net/URL;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Net.URL> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUrl), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Net.URL> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUrl", "()Ljava/net/URL;")), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jboss.Aerogear.Android.Pipe.Module.IPipeModule p0 = (global::Org.Jboss.Aerogear.Android.Pipe.Module.IPipeModule)global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Module.IPipeModule> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Module (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_module_Lorg_jboss_aerogear_android_pipe_module_PipeModule_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest']/class[@name='RestfulPipeConfiguration']/method[@name='module' and count(parameter)=1 and parameter[1][@type='org.jboss.aerogear.android.pipe.module.PipeModule']]"
		[Register ("module", "(Lorg/jboss/aerogear/android/pipe/module/PipeModule;)Lorg/jboss/aerogear/android/pipe/PipeConfiguration;", "GetModule_Lorg_jboss_aerogear_android_pipe_module_PipeModule_Handler")]
		public override unsafe global::Org.Jboss.Aerogear.Android.Pipe.PipeConfiguration Module (global::Org.Jboss.Aerogear.Android.Pipe.Module.IPipeModule p0)
		{
			if (id_module_Lorg_jboss_aerogear_android_pipe_module_PipeModule_ == IntPtr.Zero)
				id_module_Lorg_jboss_aerogear_android_pipe_module_PipeModule_ = JNIEnv.GetMethodID (class_ref, "module", "(Lorg/jboss/aerogear/android/pipe/module/PipeModule;)Lorg/jboss/aerogear/android/pipe/PipeConfiguration;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Org.Jboss.Aerogear.Android.Pipe.PipeConfiguration __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.PipeConfiguration> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_module_Lorg_jboss_aerogear_android_pipe_module_PipeModule_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.PipeConfiguration> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "module", "(Lorg/jboss/aerogear/android/pipe/module/PipeModule;)Lorg/jboss/aerogear/android/pipe/PipeConfiguration;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_pageConfig_Lorg_jboss_aerogear_android_pipe_paging_PageConfig_;
#pragma warning disable 0169
		static Delegate GetInvokePageConfig_Lorg_jboss_aerogear_android_pipe_paging_PageConfig_Handler ()
		{
			if (cb_pageConfig_Lorg_jboss_aerogear_android_pipe_paging_PageConfig_ == null)
				cb_pageConfig_Lorg_jboss_aerogear_android_pipe_paging_PageConfig_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokePageConfig_Lorg_jboss_aerogear_android_pipe_paging_PageConfig_);
			return cb_pageConfig_Lorg_jboss_aerogear_android_pipe_paging_PageConfig_;
		}

		static IntPtr n_InvokePageConfig_Lorg_jboss_aerogear_android_pipe_paging_PageConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jboss.Aerogear.Android.Pipe.Paging.PageConfig p0 = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Paging.PageConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokePageConfig (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_pageConfig_Lorg_jboss_aerogear_android_pipe_paging_PageConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest']/class[@name='RestfulPipeConfiguration']/method[@name='pageConfig' and count(parameter)=1 and parameter[1][@type='org.jboss.aerogear.android.pipe.paging.PageConfig']]"
		[Register ("pageConfig", "(Lorg/jboss/aerogear/android/pipe/paging/PageConfig;)Lorg/jboss/aerogear/android/pipe/rest/RestfulPipeConfiguration;", "GetInvokePageConfig_Lorg_jboss_aerogear_android_pipe_paging_PageConfig_Handler")]
		public virtual unsafe global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration InvokePageConfig (global::Org.Jboss.Aerogear.Android.Pipe.Paging.PageConfig p0)
		{
			if (id_pageConfig_Lorg_jboss_aerogear_android_pipe_paging_PageConfig_ == IntPtr.Zero)
				id_pageConfig_Lorg_jboss_aerogear_android_pipe_paging_PageConfig_ = JNIEnv.GetMethodID (class_ref, "pageConfig", "(Lorg/jboss/aerogear/android/pipe/paging/PageConfig;)Lorg/jboss/aerogear/android/pipe/rest/RestfulPipeConfiguration;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_pageConfig_Lorg_jboss_aerogear_android_pipe_paging_PageConfig_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pageConfig", "(Lorg/jboss/aerogear/android/pipe/paging/PageConfig;)Lorg/jboss/aerogear/android/pipe/rest/RestfulPipeConfiguration;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_requestBuilder_Lorg_jboss_aerogear_android_pipe_RequestBuilder_;
#pragma warning disable 0169
		static Delegate GetInvokeRequestBuilder_Lorg_jboss_aerogear_android_pipe_RequestBuilder_Handler ()
		{
			if (cb_requestBuilder_Lorg_jboss_aerogear_android_pipe_RequestBuilder_ == null)
				cb_requestBuilder_Lorg_jboss_aerogear_android_pipe_RequestBuilder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeRequestBuilder_Lorg_jboss_aerogear_android_pipe_RequestBuilder_);
			return cb_requestBuilder_Lorg_jboss_aerogear_android_pipe_RequestBuilder_;
		}

		static IntPtr n_InvokeRequestBuilder_Lorg_jboss_aerogear_android_pipe_RequestBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jboss.Aerogear.Android.Pipe.IRequestBuilder p0 = (global::Org.Jboss.Aerogear.Android.Pipe.IRequestBuilder)global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.IRequestBuilder> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeRequestBuilder (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_requestBuilder_Lorg_jboss_aerogear_android_pipe_RequestBuilder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest']/class[@name='RestfulPipeConfiguration']/method[@name='requestBuilder' and count(parameter)=1 and parameter[1][@type='org.jboss.aerogear.android.pipe.RequestBuilder']]"
		[Register ("requestBuilder", "(Lorg/jboss/aerogear/android/pipe/RequestBuilder;)Lorg/jboss/aerogear/android/pipe/rest/RestfulPipeConfiguration;", "GetInvokeRequestBuilder_Lorg_jboss_aerogear_android_pipe_RequestBuilder_Handler")]
		public virtual unsafe global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration InvokeRequestBuilder (global::Org.Jboss.Aerogear.Android.Pipe.IRequestBuilder p0)
		{
			if (id_requestBuilder_Lorg_jboss_aerogear_android_pipe_RequestBuilder_ == IntPtr.Zero)
				id_requestBuilder_Lorg_jboss_aerogear_android_pipe_RequestBuilder_ = JNIEnv.GetMethodID (class_ref, "requestBuilder", "(Lorg/jboss/aerogear/android/pipe/RequestBuilder;)Lorg/jboss/aerogear/android/pipe/rest/RestfulPipeConfiguration;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_requestBuilder_Lorg_jboss_aerogear_android_pipe_RequestBuilder_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestBuilder", "(Lorg/jboss/aerogear/android/pipe/RequestBuilder;)Lorg/jboss/aerogear/android/pipe/rest/RestfulPipeConfiguration;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_responseParser_Lorg_jboss_aerogear_android_pipe_ResponseParser_;
#pragma warning disable 0169
		static Delegate GetInvokeResponseParser_Lorg_jboss_aerogear_android_pipe_ResponseParser_Handler ()
		{
			if (cb_responseParser_Lorg_jboss_aerogear_android_pipe_ResponseParser_ == null)
				cb_responseParser_Lorg_jboss_aerogear_android_pipe_ResponseParser_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeResponseParser_Lorg_jboss_aerogear_android_pipe_ResponseParser_);
			return cb_responseParser_Lorg_jboss_aerogear_android_pipe_ResponseParser_;
		}

		static IntPtr n_InvokeResponseParser_Lorg_jboss_aerogear_android_pipe_ResponseParser_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jboss.Aerogear.Android.Pipe.IResponseParser p0 = (global::Org.Jboss.Aerogear.Android.Pipe.IResponseParser)global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.IResponseParser> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeResponseParser (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_responseParser_Lorg_jboss_aerogear_android_pipe_ResponseParser_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest']/class[@name='RestfulPipeConfiguration']/method[@name='responseParser' and count(parameter)=1 and parameter[1][@type='org.jboss.aerogear.android.pipe.ResponseParser']]"
		[Register ("responseParser", "(Lorg/jboss/aerogear/android/pipe/ResponseParser;)Lorg/jboss/aerogear/android/pipe/rest/RestfulPipeConfiguration;", "GetInvokeResponseParser_Lorg_jboss_aerogear_android_pipe_ResponseParser_Handler")]
		public virtual unsafe global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration InvokeResponseParser (global::Org.Jboss.Aerogear.Android.Pipe.IResponseParser p0)
		{
			if (id_responseParser_Lorg_jboss_aerogear_android_pipe_ResponseParser_ == IntPtr.Zero)
				id_responseParser_Lorg_jboss_aerogear_android_pipe_ResponseParser_ = JNIEnv.GetMethodID (class_ref, "responseParser", "(Lorg/jboss/aerogear/android/pipe/ResponseParser;)Lorg/jboss/aerogear/android/pipe/rest/RestfulPipeConfiguration;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_responseParser_Lorg_jboss_aerogear_android_pipe_ResponseParser_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "responseParser", "(Lorg/jboss/aerogear/android/pipe/ResponseParser;)Lorg/jboss/aerogear/android/pipe/rest/RestfulPipeConfiguration;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_timeout_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetInvokeTimeout_Ljava_lang_Integer_Handler ()
		{
			if (cb_timeout_Ljava_lang_Integer_ == null)
				cb_timeout_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeTimeout_Ljava_lang_Integer_);
			return cb_timeout_Ljava_lang_Integer_;
		}

		static IntPtr n_InvokeTimeout_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeTimeout (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_timeout_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest']/class[@name='RestfulPipeConfiguration']/method[@name='timeout' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("timeout", "(Ljava/lang/Integer;)Ljava/lang/Object;", "GetInvokeTimeout_Ljava_lang_Integer_Handler")]
		public virtual unsafe global::Java.Lang.Object InvokeTimeout (global::Java.Lang.Integer p0)
		{
			if (id_timeout_Ljava_lang_Integer_ == IntPtr.Zero)
				id_timeout_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "timeout", "(Ljava/lang/Integer;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_timeout_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "timeout", "(Ljava/lang/Integer;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
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
			global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Rest.RestfulPipeConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.URL p0 = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithUrl (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withUrl_Ljava_net_URL_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.rest']/class[@name='RestfulPipeConfiguration']/method[@name='withUrl' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
		[Register ("withUrl", "(Ljava/net/URL;)Lorg/jboss/aerogear/android/pipe/PipeConfiguration;", "GetWithUrl_Ljava_net_URL_Handler")]
		public override unsafe global::Org.Jboss.Aerogear.Android.Pipe.PipeConfiguration WithUrl (global::Java.Net.URL p0)
		{
			if (id_withUrl_Ljava_net_URL_ == IntPtr.Zero)
				id_withUrl_Ljava_net_URL_ = JNIEnv.GetMethodID (class_ref, "withUrl", "(Ljava/net/URL;)Lorg/jboss/aerogear/android/pipe/PipeConfiguration;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Org.Jboss.Aerogear.Android.Pipe.PipeConfiguration __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.PipeConfiguration> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withUrl_Ljava_net_URL_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.PipeConfiguration> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withUrl", "(Ljava/net/URL;)Lorg/jboss/aerogear/android/pipe/PipeConfiguration;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
