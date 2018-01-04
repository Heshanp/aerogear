using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Pipe.Loader {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.loader']/class[@name='LoaderAdapter']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/loader/LoaderAdapter", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class LoaderAdapter : global::Java.Lang.Object, global::Android.App.LoaderManager.ILoaderCallbacks {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.loader']/class[@name='LoaderAdapter.CallbackHandler']"
		[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/loader/LoaderAdapter$CallbackHandler", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public partial class CallbackHandler : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jboss/aerogear/android/pipe/loader/LoaderAdapter$CallbackHandler", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CallbackHandler); }
			}

			protected CallbackHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_jboss_aerogear_android_pipe_loader_LoaderAdapter_Lorg_jboss_aerogear_android_pipe_loader_AbstractPipeLoader_Ljava_lang_Object_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.loader']/class[@name='LoaderAdapter.CallbackHandler']/constructor[@name='LoaderAdapter.CallbackHandler' and count(parameter)=3 and parameter[1][@type='org.jboss.aerogear.android.pipe.loader.LoaderAdapter&lt;T&gt;'] and parameter[2][@type='org.jboss.aerogear.android.pipe.loader.AbstractPipeLoader'] and parameter[3][@type='java.lang.Object']]"
			[Register (".ctor", "(Lorg/jboss/aerogear/android/pipe/loader/LoaderAdapter;Lorg/jboss/aerogear/android/pipe/loader/AbstractPipeLoader;Ljava/lang/Object;)V", "")]
			public unsafe CallbackHandler (global::Org.Jboss.Aerogear.Android.Pipe.Loader.LoaderAdapter p0, global::Org.Jboss.Aerogear.Android.Pipe.Loader.AbstractPipeLoader p1, global::Java.Lang.Object p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					if (((object) this).GetType () != typeof (CallbackHandler)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/jboss/aerogear/android/pipe/loader/LoaderAdapter;Lorg/jboss/aerogear/android/pipe/loader/AbstractPipeLoader;Ljava/lang/Object;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jboss/aerogear/android/pipe/loader/LoaderAdapter;Lorg/jboss/aerogear/android/pipe/loader/AbstractPipeLoader;Ljava/lang/Object;)V", __args);
						return;
					}

					if (id_ctor_Lorg_jboss_aerogear_android_pipe_loader_LoaderAdapter_Lorg_jboss_aerogear_android_pipe_loader_AbstractPipeLoader_Ljava_lang_Object_ == IntPtr.Zero)
						id_ctor_Lorg_jboss_aerogear_android_pipe_loader_LoaderAdapter_Lorg_jboss_aerogear_android_pipe_loader_AbstractPipeLoader_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jboss/aerogear/android/pipe/loader/LoaderAdapter;Lorg/jboss/aerogear/android/pipe/loader/AbstractPipeLoader;Ljava/lang/Object;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jboss_aerogear_android_pipe_loader_LoaderAdapter_Lorg_jboss_aerogear_android_pipe_loader_AbstractPipeLoader_Ljava_lang_Object_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jboss_aerogear_android_pipe_loader_LoaderAdapter_Lorg_jboss_aerogear_android_pipe_loader_AbstractPipeLoader_Ljava_lang_Object_, __args);
				} finally {
				}
			}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jboss.Aerogear.Android.Pipe.Loader.LoaderAdapter.CallbackHandler __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Loader.LoaderAdapter.CallbackHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.loader']/class[@name='LoaderAdapter.CallbackHandler']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual unsafe void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.loader']/class[@name='LoaderAdapter.Methods']"
		[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/loader/LoaderAdapter$Methods", DoNotGenerateAcw=true)]
		public sealed partial class Methods : global::Java.Lang.Enum {


			static IntPtr READ_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.loader']/class[@name='LoaderAdapter.Methods']/field[@name='READ']"
			[Register ("READ")]
			public static global::Org.Jboss.Aerogear.Android.Pipe.Loader.LoaderAdapter.Methods Read {
				get {
					if (READ_jfieldId == IntPtr.Zero)
						READ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "READ", "Lorg/jboss/aerogear/android/pipe/loader/LoaderAdapter$Methods;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, READ_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Loader.LoaderAdapter.Methods> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr READ_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.loader']/class[@name='LoaderAdapter.Methods']/field[@name='READ_ID']"
			[Register ("READ_ID")]
			public static global::Org.Jboss.Aerogear.Android.Pipe.Loader.LoaderAdapter.Methods ReadId {
				get {
					if (READ_ID_jfieldId == IntPtr.Zero)
						READ_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "READ_ID", "Lorg/jboss/aerogear/android/pipe/loader/LoaderAdapter$Methods;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, READ_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Loader.LoaderAdapter.Methods> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REMOVE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.loader']/class[@name='LoaderAdapter.Methods']/field[@name='REMOVE']"
			[Register ("REMOVE")]
			public static global::Org.Jboss.Aerogear.Android.Pipe.Loader.LoaderAdapter.Methods Remove {
				get {
					if (REMOVE_jfieldId == IntPtr.Zero)
						REMOVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REMOVE", "Lorg/jboss/aerogear/android/pipe/loader/LoaderAdapter$Methods;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REMOVE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Loader.LoaderAdapter.Methods> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SAVE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.loader']/class[@name='LoaderAdapter.Methods']/field[@name='SAVE']"
			[Register ("SAVE")]
			public static global::Org.Jboss.Aerogear.Android.Pipe.Loader.LoaderAdapter.Methods Save {
				get {
					if (SAVE_jfieldId == IntPtr.Zero)
						SAVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SAVE", "Lorg/jboss/aerogear/android/pipe/loader/LoaderAdapter$Methods;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SAVE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Loader.LoaderAdapter.Methods> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jboss/aerogear/android/pipe/loader/LoaderAdapter$Methods", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Methods); }
			}

			internal Methods (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/pipe/loader/LoaderAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LoaderAdapter); }
		}

		protected LoaderAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getKlass;
#pragma warning disable 0169
		static Delegate GetGetKlassHandler ()
		{
			if (cb_getKlass == null)
				cb_getKlass = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKlass);
			return cb_getKlass;
		}

		static IntPtr n_GetKlass (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Loader.LoaderAdapter __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Loader.LoaderAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Klass);
		}
#pragma warning restore 0169

		static IntPtr id_getKlass;
		public virtual unsafe global::Java.Lang.Class Klass {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.loader']/class[@name='LoaderAdapter']/method[@name='getKlass' and count(parameter)=0]"
			[Register ("getKlass", "()Ljava/lang/Class;", "GetGetKlassHandler")]
			get {
				if (id_getKlass == IntPtr.Zero)
					id_getKlass = JNIEnv.GetMethodID (class_ref, "getKlass", "()Ljava/lang/Class;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKlass), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKlass", "()Ljava/lang/Class;")), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Jboss.Aerogear.Android.Pipe.Loader.LoaderAdapter __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Loader.LoaderAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RequestBuilder);
		}
#pragma warning restore 0169

		static IntPtr id_getRequestBuilder;
		public virtual unsafe global::Org.Jboss.Aerogear.Android.Pipe.IRequestBuilder RequestBuilder {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.loader']/class[@name='LoaderAdapter']/method[@name='getRequestBuilder' and count(parameter)=0]"
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
			global::Org.Jboss.Aerogear.Android.Pipe.Loader.LoaderAdapter __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Loader.LoaderAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ResponseParser);
		}
#pragma warning restore 0169

		static IntPtr id_getResponseParser;
		public virtual unsafe global::Org.Jboss.Aerogear.Android.Pipe.IResponseParser ResponseParser {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.loader']/class[@name='LoaderAdapter']/method[@name='getResponseParser' and count(parameter)=0]"
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
			global::Org.Jboss.Aerogear.Android.Pipe.Loader.LoaderAdapter __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Loader.LoaderAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Url);
		}
#pragma warning restore 0169

		static IntPtr id_getUrl;
		public virtual unsafe global::Java.Net.URL Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.loader']/class[@name='LoaderAdapter']/method[@name='getUrl' and count(parameter)=0]"
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

		static Delegate cb_onCreateLoader_ILandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnCreateLoader_ILandroid_os_Bundle_Handler ()
		{
			if (cb_onCreateLoader_ILandroid_os_Bundle_ == null)
				cb_onCreateLoader_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_OnCreateLoader_ILandroid_os_Bundle_);
			return cb_onCreateLoader_ILandroid_os_Bundle_;
		}

		static IntPtr n_OnCreateLoader_ILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Loader.LoaderAdapter __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Loader.LoaderAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateLoader (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onCreateLoader_ILandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.loader']/class[@name='LoaderAdapter']/method[@name='onCreateLoader' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("onCreateLoader", "(ILandroid/os/Bundle;)Landroid/content/Loader;", "GetOnCreateLoader_ILandroid_os_Bundle_Handler")]
		public virtual unsafe global::Android.Content.Loader OnCreateLoader (int p0, global::Android.OS.Bundle p1)
		{
			if (id_onCreateLoader_ILandroid_os_Bundle_ == IntPtr.Zero)
				id_onCreateLoader_ILandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onCreateLoader", "(ILandroid/os/Bundle;)Landroid/content/Loader;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Android.Content.Loader __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Content.Loader> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onCreateLoader_ILandroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Content.Loader> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreateLoader", "(ILandroid/os/Bundle;)Landroid/content/Loader;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onLoadFinished_Landroid_content_Loader_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnLoadFinished_Landroid_content_Loader_Ljava_lang_Object_Handler ()
		{
			if (cb_onLoadFinished_Landroid_content_Loader_Ljava_lang_Object_ == null)
				cb_onLoadFinished_Landroid_content_Loader_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnLoadFinished_Landroid_content_Loader_Ljava_lang_Object_);
			return cb_onLoadFinished_Landroid_content_Loader_Ljava_lang_Object_;
		}

		static void n_OnLoadFinished_Landroid_content_Loader_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Loader.LoaderAdapter __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Loader.LoaderAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Loader p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Loader> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnLoadFinished (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onLoadFinished_Landroid_content_Loader_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.loader']/class[@name='LoaderAdapter']/method[@name='onLoadFinished' and count(parameter)=2 and parameter[1][@type='android.content.Loader&lt;org.jboss.aerogear.android.pipe.http.HeaderAndBody&gt;'] and parameter[2][@type='Java.Lang.Object']]"
		[Register ("onLoadFinished", "(Landroid/content/Loader;Ljava/lang/Object;)V", "GetOnLoadFinished_Landroid_content_Loader_Ljava_lang_Object_Handler")]
		public virtual unsafe void OnLoadFinished (global::Android.Content.Loader p0, global::Java.Lang.Object p1)
		{
			if (id_onLoadFinished_Landroid_content_Loader_Ljava_lang_Object_ == IntPtr.Zero)
				id_onLoadFinished_Landroid_content_Loader_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onLoadFinished", "(Landroid/content/Loader;Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLoadFinished_Landroid_content_Loader_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLoadFinished", "(Landroid/content/Loader;Ljava/lang/Object;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onLoaderReset_Landroid_content_Loader_;
#pragma warning disable 0169
		static Delegate GetOnLoaderReset_Landroid_content_Loader_Handler ()
		{
			if (cb_onLoaderReset_Landroid_content_Loader_ == null)
				cb_onLoaderReset_Landroid_content_Loader_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLoaderReset_Landroid_content_Loader_);
			return cb_onLoaderReset_Landroid_content_Loader_;
		}

		static void n_OnLoaderReset_Landroid_content_Loader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Loader.LoaderAdapter __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Loader.LoaderAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Loader p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Loader> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLoaderReset (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onLoaderReset_Landroid_content_Loader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.loader']/class[@name='LoaderAdapter']/method[@name='onLoaderReset' and count(parameter)=1 and parameter[1][@type='android.content.Loader&lt;org.jboss.aerogear.android.pipe.http.HeaderAndBody&gt;']]"
		[Register ("onLoaderReset", "(Landroid/content/Loader;)V", "GetOnLoaderReset_Landroid_content_Loader_Handler")]
		public virtual unsafe void OnLoaderReset (global::Android.Content.Loader p0)
		{
			if (id_onLoaderReset_Landroid_content_Loader_ == IntPtr.Zero)
				id_onLoaderReset_Landroid_content_Loader_ = JNIEnv.GetMethodID (class_ref, "onLoaderReset", "(Landroid/content/Loader;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLoaderReset_Landroid_content_Loader_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLoaderReset", "(Landroid/content/Loader;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Loader.LoaderAdapter __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Loader.LoaderAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.loader']/class[@name='LoaderAdapter']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "()V"));
			} finally {
			}
		}

		static Delegate cb_setLoaderIds_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetLoaderIds_Ljava_util_Map_Handler ()
		{
			if (cb_setLoaderIds_Ljava_util_Map_ == null)
				cb_setLoaderIds_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLoaderIds_Ljava_util_Map_);
			return cb_setLoaderIds_Ljava_util_Map_;
		}

		static void n_SetLoaderIds_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Loader.LoaderAdapter __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Loader.LoaderAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<global::Java.Lang.Integer>>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLoaderIds (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLoaderIds_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.loader']/class[@name='LoaderAdapter']/method[@name='setLoaderIds' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.util.List&lt;java.lang.Integer&gt;&gt;']]"
		[Register ("setLoaderIds", "(Ljava/util/Map;)V", "GetSetLoaderIds_Ljava_util_Map_Handler")]
		public virtual unsafe void SetLoaderIds (global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<global::Java.Lang.Integer>> p0)
		{
			if (id_setLoaderIds_Ljava_util_Map_ == IntPtr.Zero)
				id_setLoaderIds_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setLoaderIds", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<global::Java.Lang.Integer>>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLoaderIds_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLoaderIds", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
