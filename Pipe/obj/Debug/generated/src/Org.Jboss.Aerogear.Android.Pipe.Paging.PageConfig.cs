using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Pipe.Paging {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.paging']/class[@name='PageConfig']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/paging/PageConfig", DoNotGenerateAcw=true)]
	public partial class PageConfig : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.paging']/class[@name='PageConfig.MetadataLocations']"
		[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/paging/PageConfig$MetadataLocations", DoNotGenerateAcw=true)]
		public sealed partial class MetadataLocations : global::Java.Lang.Enum, global::Org.Jboss.Aerogear.Android.Pipe.Paging.IMetadataLocation {


			static IntPtr BODY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.paging']/class[@name='PageConfig.MetadataLocations']/field[@name='BODY']"
			[Register ("BODY")]
			public static global::Org.Jboss.Aerogear.Android.Pipe.Paging.PageConfig.MetadataLocations Body {
				get {
					if (BODY_jfieldId == IntPtr.Zero)
						BODY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BODY", "Lorg/jboss/aerogear/android/pipe/paging/PageConfig$MetadataLocations;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BODY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Paging.PageConfig.MetadataLocations> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr HEADERS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.paging']/class[@name='PageConfig.MetadataLocations']/field[@name='HEADERS']"
			[Register ("HEADERS")]
			public static global::Org.Jboss.Aerogear.Android.Pipe.Paging.PageConfig.MetadataLocations Headers {
				get {
					if (HEADERS_jfieldId == IntPtr.Zero)
						HEADERS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HEADERS", "Lorg/jboss/aerogear/android/pipe/paging/PageConfig$MetadataLocations;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HEADERS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Paging.PageConfig.MetadataLocations> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr WEB_LINKING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.paging']/class[@name='PageConfig.MetadataLocations']/field[@name='WEB_LINKING']"
			[Register ("WEB_LINKING")]
			public static global::Org.Jboss.Aerogear.Android.Pipe.Paging.PageConfig.MetadataLocations WebLinking {
				get {
					if (WEB_LINKING_jfieldId == IntPtr.Zero)
						WEB_LINKING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WEB_LINKING", "Lorg/jboss/aerogear/android/pipe/paging/PageConfig$MetadataLocations;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WEB_LINKING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Paging.PageConfig.MetadataLocations> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jboss/aerogear/android/pipe/paging/PageConfig$MetadataLocations", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MetadataLocations); }
			}

			internal MetadataLocations (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.paging']/class[@name='PageConfig.MetadataLocations']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/jboss/aerogear/android/pipe/paging/PageConfig$MetadataLocations;", "")]
			public static unsafe global::Org.Jboss.Aerogear.Android.Pipe.Paging.PageConfig.MetadataLocations ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/jboss/aerogear/android/pipe/paging/PageConfig$MetadataLocations;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Org.Jboss.Aerogear.Android.Pipe.Paging.PageConfig.MetadataLocations __ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Paging.PageConfig.MetadataLocations> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.paging']/class[@name='PageConfig.MetadataLocations']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/jboss/aerogear/android/pipe/paging/PageConfig$MetadataLocations;", "")]
			public static unsafe global::Org.Jboss.Aerogear.Android.Pipe.Paging.PageConfig.MetadataLocations[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/jboss/aerogear/android/pipe/paging/PageConfig$MetadataLocations;");
				try {
					return (global::Org.Jboss.Aerogear.Android.Pipe.Paging.PageConfig.MetadataLocations[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jboss.Aerogear.Android.Pipe.Paging.PageConfig.MetadataLocations));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/pipe/paging/PageConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PageConfig); }
		}

		protected PageConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.paging']/class[@name='PageConfig']/constructor[@name='PageConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PageConfig ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PageConfig)) {
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

		static Delegate cb_getLimitValue;
#pragma warning disable 0169
		static Delegate GetGetLimitValueHandler ()
		{
			if (cb_getLimitValue == null)
				cb_getLimitValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLimitValue);
			return cb_getLimitValue;
		}

		static IntPtr n_GetLimitValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Paging.PageConfig __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Paging.PageConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LimitValue);
		}
#pragma warning restore 0169

		static Delegate cb_setLimitValue_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetLimitValue_Ljava_lang_Integer_Handler ()
		{
			if (cb_setLimitValue_Ljava_lang_Integer_ == null)
				cb_setLimitValue_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLimitValue_Ljava_lang_Integer_);
			return cb_setLimitValue_Ljava_lang_Integer_;
		}

		static void n_SetLimitValue_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Paging.PageConfig __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Paging.PageConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LimitValue = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLimitValue;
		static IntPtr id_setLimitValue_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer LimitValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.paging']/class[@name='PageConfig']/method[@name='getLimitValue' and count(parameter)=0]"
			[Register ("getLimitValue", "()Ljava/lang/Integer;", "GetGetLimitValueHandler")]
			get {
				if (id_getLimitValue == IntPtr.Zero)
					id_getLimitValue = JNIEnv.GetMethodID (class_ref, "getLimitValue", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLimitValue), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLimitValue", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.paging']/class[@name='PageConfig']/method[@name='setLimitValue' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setLimitValue", "(Ljava/lang/Integer;)V", "GetSetLimitValue_Ljava_lang_Integer_Handler")]
			set {
				if (id_setLimitValue_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setLimitValue_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setLimitValue", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLimitValue_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLimitValue", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMetadataLocation;
#pragma warning disable 0169
		static Delegate GetGetMetadataLocationHandler ()
		{
			if (cb_getMetadataLocation == null)
				cb_getMetadataLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMetadataLocation);
			return cb_getMetadataLocation;
		}

		static IntPtr n_GetMetadataLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Paging.PageConfig __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Paging.PageConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MetadataLocation);
		}
#pragma warning restore 0169

		static Delegate cb_setMetadataLocation_Lorg_jboss_aerogear_android_pipe_paging_MetadataLocation_;
#pragma warning disable 0169
		static Delegate GetSetMetadataLocation_Lorg_jboss_aerogear_android_pipe_paging_MetadataLocation_Handler ()
		{
			if (cb_setMetadataLocation_Lorg_jboss_aerogear_android_pipe_paging_MetadataLocation_ == null)
				cb_setMetadataLocation_Lorg_jboss_aerogear_android_pipe_paging_MetadataLocation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMetadataLocation_Lorg_jboss_aerogear_android_pipe_paging_MetadataLocation_);
			return cb_setMetadataLocation_Lorg_jboss_aerogear_android_pipe_paging_MetadataLocation_;
		}

		static void n_SetMetadataLocation_Lorg_jboss_aerogear_android_pipe_paging_MetadataLocation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Paging.PageConfig __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Paging.PageConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jboss.Aerogear.Android.Pipe.Paging.IMetadataLocation p0 = (global::Org.Jboss.Aerogear.Android.Pipe.Paging.IMetadataLocation)global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Paging.IMetadataLocation> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MetadataLocation = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMetadataLocation;
		static IntPtr id_setMetadataLocation_Lorg_jboss_aerogear_android_pipe_paging_MetadataLocation_;
		public virtual unsafe global::Org.Jboss.Aerogear.Android.Pipe.Paging.IMetadataLocation MetadataLocation {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.paging']/class[@name='PageConfig']/method[@name='getMetadataLocation' and count(parameter)=0]"
			[Register ("getMetadataLocation", "()Lorg/jboss/aerogear/android/pipe/paging/MetadataLocation;", "GetGetMetadataLocationHandler")]
			get {
				if (id_getMetadataLocation == IntPtr.Zero)
					id_getMetadataLocation = JNIEnv.GetMethodID (class_ref, "getMetadataLocation", "()Lorg/jboss/aerogear/android/pipe/paging/MetadataLocation;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Paging.IMetadataLocation> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMetadataLocation), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Paging.IMetadataLocation> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMetadataLocation", "()Lorg/jboss/aerogear/android/pipe/paging/MetadataLocation;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.paging']/class[@name='PageConfig']/method[@name='setMetadataLocation' and count(parameter)=1 and parameter[1][@type='org.jboss.aerogear.android.pipe.paging.MetadataLocation']]"
			[Register ("setMetadataLocation", "(Lorg/jboss/aerogear/android/pipe/paging/MetadataLocation;)V", "GetSetMetadataLocation_Lorg_jboss_aerogear_android_pipe_paging_MetadataLocation_Handler")]
			set {
				if (id_setMetadataLocation_Lorg_jboss_aerogear_android_pipe_paging_MetadataLocation_ == IntPtr.Zero)
					id_setMetadataLocation_Lorg_jboss_aerogear_android_pipe_paging_MetadataLocation_ = JNIEnv.GetMethodID (class_ref, "setMetadataLocation", "(Lorg/jboss/aerogear/android/pipe/paging/MetadataLocation;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMetadataLocation_Lorg_jboss_aerogear_android_pipe_paging_MetadataLocation_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMetadataLocation", "(Lorg/jboss/aerogear/android/pipe/paging/MetadataLocation;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNextIdentifier;
#pragma warning disable 0169
		static Delegate GetGetNextIdentifierHandler ()
		{
			if (cb_getNextIdentifier == null)
				cb_getNextIdentifier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNextIdentifier);
			return cb_getNextIdentifier;
		}

		static IntPtr n_GetNextIdentifier (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Paging.PageConfig __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Paging.PageConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NextIdentifier);
		}
#pragma warning restore 0169

		static Delegate cb_setNextIdentifier_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNextIdentifier_Ljava_lang_String_Handler ()
		{
			if (cb_setNextIdentifier_Ljava_lang_String_ == null)
				cb_setNextIdentifier_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNextIdentifier_Ljava_lang_String_);
			return cb_setNextIdentifier_Ljava_lang_String_;
		}

		static void n_SetNextIdentifier_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Paging.PageConfig __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Paging.PageConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NextIdentifier = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNextIdentifier;
		static IntPtr id_setNextIdentifier_Ljava_lang_String_;
		public virtual unsafe string NextIdentifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.paging']/class[@name='PageConfig']/method[@name='getNextIdentifier' and count(parameter)=0]"
			[Register ("getNextIdentifier", "()Ljava/lang/String;", "GetGetNextIdentifierHandler")]
			get {
				if (id_getNextIdentifier == IntPtr.Zero)
					id_getNextIdentifier = JNIEnv.GetMethodID (class_ref, "getNextIdentifier", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNextIdentifier), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNextIdentifier", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.paging']/class[@name='PageConfig']/method[@name='setNextIdentifier' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNextIdentifier", "(Ljava/lang/String;)V", "GetSetNextIdentifier_Ljava_lang_String_Handler")]
			set {
				if (id_setNextIdentifier_Ljava_lang_String_ == IntPtr.Zero)
					id_setNextIdentifier_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNextIdentifier", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNextIdentifier_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNextIdentifier", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getOffsetValue;
#pragma warning disable 0169
		static Delegate GetGetOffsetValueHandler ()
		{
			if (cb_getOffsetValue == null)
				cb_getOffsetValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOffsetValue);
			return cb_getOffsetValue;
		}

		static IntPtr n_GetOffsetValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Paging.PageConfig __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Paging.PageConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OffsetValue);
		}
#pragma warning restore 0169

		static Delegate cb_setOffsetValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOffsetValue_Ljava_lang_String_Handler ()
		{
			if (cb_setOffsetValue_Ljava_lang_String_ == null)
				cb_setOffsetValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOffsetValue_Ljava_lang_String_);
			return cb_setOffsetValue_Ljava_lang_String_;
		}

		static void n_SetOffsetValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Paging.PageConfig __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Paging.PageConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OffsetValue = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOffsetValue;
		static IntPtr id_setOffsetValue_Ljava_lang_String_;
		public virtual unsafe string OffsetValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.paging']/class[@name='PageConfig']/method[@name='getOffsetValue' and count(parameter)=0]"
			[Register ("getOffsetValue", "()Ljava/lang/String;", "GetGetOffsetValueHandler")]
			get {
				if (id_getOffsetValue == IntPtr.Zero)
					id_getOffsetValue = JNIEnv.GetMethodID (class_ref, "getOffsetValue", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOffsetValue), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOffsetValue", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.paging']/class[@name='PageConfig']/method[@name='setOffsetValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setOffsetValue", "(Ljava/lang/String;)V", "GetSetOffsetValue_Ljava_lang_String_Handler")]
			set {
				if (id_setOffsetValue_Ljava_lang_String_ == IntPtr.Zero)
					id_setOffsetValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setOffsetValue", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOffsetValue_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOffsetValue", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getPreviousIdentifier;
#pragma warning disable 0169
		static Delegate GetGetPreviousIdentifierHandler ()
		{
			if (cb_getPreviousIdentifier == null)
				cb_getPreviousIdentifier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPreviousIdentifier);
			return cb_getPreviousIdentifier;
		}

		static IntPtr n_GetPreviousIdentifier (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Paging.PageConfig __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Paging.PageConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PreviousIdentifier);
		}
#pragma warning restore 0169

		static Delegate cb_setPreviousIdentifier_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPreviousIdentifier_Ljava_lang_String_Handler ()
		{
			if (cb_setPreviousIdentifier_Ljava_lang_String_ == null)
				cb_setPreviousIdentifier_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPreviousIdentifier_Ljava_lang_String_);
			return cb_setPreviousIdentifier_Ljava_lang_String_;
		}

		static void n_SetPreviousIdentifier_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jboss.Aerogear.Android.Pipe.Paging.PageConfig __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.Paging.PageConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PreviousIdentifier = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPreviousIdentifier;
		static IntPtr id_setPreviousIdentifier_Ljava_lang_String_;
		public virtual unsafe string PreviousIdentifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.paging']/class[@name='PageConfig']/method[@name='getPreviousIdentifier' and count(parameter)=0]"
			[Register ("getPreviousIdentifier", "()Ljava/lang/String;", "GetGetPreviousIdentifierHandler")]
			get {
				if (id_getPreviousIdentifier == IntPtr.Zero)
					id_getPreviousIdentifier = JNIEnv.GetMethodID (class_ref, "getPreviousIdentifier", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPreviousIdentifier), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPreviousIdentifier", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.paging']/class[@name='PageConfig']/method[@name='setPreviousIdentifier' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPreviousIdentifier", "(Ljava/lang/String;)V", "GetSetPreviousIdentifier_Ljava_lang_String_Handler")]
			set {
				if (id_setPreviousIdentifier_Ljava_lang_String_ == IntPtr.Zero)
					id_setPreviousIdentifier_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPreviousIdentifier", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPreviousIdentifier_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPreviousIdentifier", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
