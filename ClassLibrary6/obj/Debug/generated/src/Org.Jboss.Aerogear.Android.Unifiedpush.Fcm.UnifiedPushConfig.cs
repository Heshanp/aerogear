using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Unifiedpush.Fcm {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.fcm']/class[@name='UnifiedPushConfig']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/unifiedpush/fcm/UnifiedPushConfig", DoNotGenerateAcw=true)]
	public sealed partial class UnifiedPushConfig : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/unifiedpush/fcm/UnifiedPushConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UnifiedPushConfig); }
		}

		internal UnifiedPushConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.fcm']/class[@name='UnifiedPushConfig']/constructor[@name='UnifiedPushConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UnifiedPushConfig ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (UnifiedPushConfig)) {
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

		static IntPtr id_getAlias;
		public unsafe string Alias {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.fcm']/class[@name='UnifiedPushConfig']/method[@name='getAlias' and count(parameter)=0]"
			[Register ("getAlias", "()Ljava/lang/String;", "GetGetAliasHandler")]
			get {
				if (id_getAlias == IntPtr.Zero)
					id_getAlias = JNIEnv.GetMethodID (class_ref, "getAlias", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAlias), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getCategories;
		public unsafe global::System.Collections.Generic.IList<string> Categories {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.fcm']/class[@name='UnifiedPushConfig']/method[@name='getCategories' and count(parameter)=0]"
			[Register ("getCategories", "()Ljava/util/List;", "GetGetCategoriesHandler")]
			get {
				if (id_getCategories == IntPtr.Zero)
					id_getCategories = JNIEnv.GetMethodID (class_ref, "getCategories", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCategories), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getDeviceToken;
		public unsafe string DeviceToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.fcm']/class[@name='UnifiedPushConfig']/method[@name='getDeviceToken' and count(parameter)=0]"
			[Register ("getDeviceToken", "()Ljava/lang/String;", "GetGetDeviceTokenHandler")]
			get {
				if (id_getDeviceToken == IntPtr.Zero)
					id_getDeviceToken = JNIEnv.GetMethodID (class_ref, "getDeviceToken", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceToken), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getDeviceType;
		public unsafe string DeviceType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.fcm']/class[@name='UnifiedPushConfig']/method[@name='getDeviceType' and count(parameter)=0]"
			[Register ("getDeviceType", "()Ljava/lang/String;", "GetGetDeviceTypeHandler")]
			get {
				if (id_getDeviceType == IntPtr.Zero)
					id_getDeviceType = JNIEnv.GetMethodID (class_ref, "getDeviceType", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceType), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getOperatingSystem;
		public unsafe string OperatingSystem {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.fcm']/class[@name='UnifiedPushConfig']/method[@name='getOperatingSystem' and count(parameter)=0]"
			[Register ("getOperatingSystem", "()Ljava/lang/String;", "GetGetOperatingSystemHandler")]
			get {
				if (id_getOperatingSystem == IntPtr.Zero)
					id_getOperatingSystem = JNIEnv.GetMethodID (class_ref, "getOperatingSystem", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOperatingSystem), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getOsVersion;
		public unsafe string OsVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.fcm']/class[@name='UnifiedPushConfig']/method[@name='getOsVersion' and count(parameter)=0]"
			[Register ("getOsVersion", "()Ljava/lang/String;", "GetGetOsVersionHandler")]
			get {
				if (id_getOsVersion == IntPtr.Zero)
					id_getOsVersion = JNIEnv.GetMethodID (class_ref, "getOsVersion", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOsVersion), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getPushServerURI;
		public unsafe global::Java.Net.URI PushServerURI {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.fcm']/class[@name='UnifiedPushConfig']/method[@name='getPushServerURI' and count(parameter)=0]"
			[Register ("getPushServerURI", "()Ljava/net/URI;", "GetGetPushServerURIHandler")]
			get {
				if (id_getPushServerURI == IntPtr.Zero)
					id_getPushServerURI = JNIEnv.GetMethodID (class_ref, "getPushServerURI", "()Ljava/net/URI;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Net.URI> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPushServerURI), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSecret;
		public unsafe string Secret {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.fcm']/class[@name='UnifiedPushConfig']/method[@name='getSecret' and count(parameter)=0]"
			[Register ("getSecret", "()Ljava/lang/String;", "GetGetSecretHandler")]
			get {
				if (id_getSecret == IntPtr.Zero)
					id_getSecret = JNIEnv.GetMethodID (class_ref, "getSecret", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSecret), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSenderId;
		public unsafe string SenderId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.fcm']/class[@name='UnifiedPushConfig']/method[@name='getSenderId' and count(parameter)=0]"
			[Register ("getSenderId", "()Ljava/lang/String;", "GetGetSenderIdHandler")]
			get {
				if (id_getSenderId == IntPtr.Zero)
					id_getSenderId = JNIEnv.GetMethodID (class_ref, "getSenderId", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSenderId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getVariantID;
		public unsafe string VariantID {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.fcm']/class[@name='UnifiedPushConfig']/method[@name='getVariantID' and count(parameter)=0]"
			[Register ("getVariantID", "()Ljava/lang/String;", "GetGetVariantIDHandler")]
			get {
				if (id_getVariantID == IntPtr.Zero)
					id_getVariantID = JNIEnv.GetMethodID (class_ref, "getVariantID", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVariantID), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_addCategories_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.fcm']/class[@name='UnifiedPushConfig']/method[@name='addCategories' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("addCategories", "(Ljava/util/List;)Lorg/jboss/aerogear/android/unifiedpush/fcm/UnifiedPushConfig;", "")]
		public unsafe global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.UnifiedPushConfig AddCategories (global::System.Collections.Generic.IList<string> categories)
		{
			if (id_addCategories_Ljava_util_List_ == IntPtr.Zero)
				id_addCategories_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "addCategories", "(Ljava/util/List;)Lorg/jboss/aerogear/android/unifiedpush/fcm/UnifiedPushConfig;");
			IntPtr native_categories = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (categories);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_categories);
				global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.UnifiedPushConfig __ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.UnifiedPushConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addCategories_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_categories);
			}
		}

		static IntPtr id_addCategory_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.fcm']/class[@name='UnifiedPushConfig']/method[@name='addCategory' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addCategory", "(Ljava/lang/String;)Lorg/jboss/aerogear/android/unifiedpush/fcm/UnifiedPushConfig;", "")]
		public unsafe global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.UnifiedPushConfig AddCategory (string category)
		{
			if (id_addCategory_Ljava_lang_String_ == IntPtr.Zero)
				id_addCategory_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addCategory", "(Ljava/lang/String;)Lorg/jboss/aerogear/android/unifiedpush/fcm/UnifiedPushConfig;");
			IntPtr native_category = JNIEnv.NewString (category);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_category);
				global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.UnifiedPushConfig __ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.UnifiedPushConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addCategory_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_category);
			}
		}

		static IntPtr id_checkRequiredFields;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.fcm']/class[@name='UnifiedPushConfig']/method[@name='checkRequiredFields' and count(parameter)=0]"
		[Register ("checkRequiredFields", "()V", "")]
		public unsafe void CheckRequiredFields ()
		{
			if (id_checkRequiredFields == IntPtr.Zero)
				id_checkRequiredFields = JNIEnv.GetMethodID (class_ref, "checkRequiredFields", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_checkRequiredFields);
			} finally {
			}
		}

		static IntPtr id_setAlias_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.fcm']/class[@name='UnifiedPushConfig']/method[@name='setAlias' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAlias", "(Ljava/lang/String;)Lorg/jboss/aerogear/android/unifiedpush/fcm/UnifiedPushConfig;", "")]
		public unsafe global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.UnifiedPushConfig SetAlias (string alias)
		{
			if (id_setAlias_Ljava_lang_String_ == IntPtr.Zero)
				id_setAlias_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAlias", "(Ljava/lang/String;)Lorg/jboss/aerogear/android/unifiedpush/fcm/UnifiedPushConfig;");
			IntPtr native_alias = JNIEnv.NewString (alias);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_alias);
				global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.UnifiedPushConfig __ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.UnifiedPushConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setAlias_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_alias);
			}
		}

		static IntPtr id_setCategories_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.fcm']/class[@name='UnifiedPushConfig']/method[@name='setCategories' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("setCategories", "([Ljava/lang/String;)Lorg/jboss/aerogear/android/unifiedpush/fcm/UnifiedPushConfig;", "")]
		public unsafe global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.UnifiedPushConfig SetCategories (params  string[] categories)
		{
			if (id_setCategories_arrayLjava_lang_String_ == IntPtr.Zero)
				id_setCategories_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCategories", "([Ljava/lang/String;)Lorg/jboss/aerogear/android/unifiedpush/fcm/UnifiedPushConfig;");
			IntPtr native_categories = JNIEnv.NewArray (categories);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_categories);
				global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.UnifiedPushConfig __ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.UnifiedPushConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCategories_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (categories != null) {
					JNIEnv.CopyArray (native_categories, categories);
					JNIEnv.DeleteLocalRef (native_categories);
				}
			}
		}

		static IntPtr id_setCategories_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.fcm']/class[@name='UnifiedPushConfig']/method[@name='setCategories' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("setCategories", "(Ljava/util/List;)Lorg/jboss/aerogear/android/unifiedpush/fcm/UnifiedPushConfig;", "")]
		public unsafe global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.UnifiedPushConfig SetCategories (global::System.Collections.Generic.IList<string> categories)
		{
			if (id_setCategories_Ljava_util_List_ == IntPtr.Zero)
				id_setCategories_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setCategories", "(Ljava/util/List;)Lorg/jboss/aerogear/android/unifiedpush/fcm/UnifiedPushConfig;");
			IntPtr native_categories = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (categories);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_categories);
				global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.UnifiedPushConfig __ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.UnifiedPushConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCategories_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_categories);
			}
		}

		static IntPtr id_setDeviceType_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.fcm']/class[@name='UnifiedPushConfig']/method[@name='setDeviceType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setDeviceType", "(Ljava/lang/String;)Lorg/jboss/aerogear/android/unifiedpush/fcm/UnifiedPushConfig;", "")]
		public unsafe global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.UnifiedPushConfig SetDeviceType (string deviceType)
		{
			if (id_setDeviceType_Ljava_lang_String_ == IntPtr.Zero)
				id_setDeviceType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDeviceType", "(Ljava/lang/String;)Lorg/jboss/aerogear/android/unifiedpush/fcm/UnifiedPushConfig;");
			IntPtr native_deviceType = JNIEnv.NewString (deviceType);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_deviceType);
				global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.UnifiedPushConfig __ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.UnifiedPushConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDeviceType_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_deviceType);
			}
		}

		static IntPtr id_setOperatingSystem_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.fcm']/class[@name='UnifiedPushConfig']/method[@name='setOperatingSystem' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setOperatingSystem", "(Ljava/lang/String;)Lorg/jboss/aerogear/android/unifiedpush/fcm/UnifiedPushConfig;", "")]
		public unsafe global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.UnifiedPushConfig SetOperatingSystem (string operatingSystem)
		{
			if (id_setOperatingSystem_Ljava_lang_String_ == IntPtr.Zero)
				id_setOperatingSystem_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setOperatingSystem", "(Ljava/lang/String;)Lorg/jboss/aerogear/android/unifiedpush/fcm/UnifiedPushConfig;");
			IntPtr native_operatingSystem = JNIEnv.NewString (operatingSystem);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_operatingSystem);
				global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.UnifiedPushConfig __ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.UnifiedPushConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setOperatingSystem_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_operatingSystem);
			}
		}

		static IntPtr id_setPushServerURI_Ljava_net_URI_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.fcm']/class[@name='UnifiedPushConfig']/method[@name='setPushServerURI' and count(parameter)=1 and parameter[1][@type='java.net.URI']]"
		[Register ("setPushServerURI", "(Ljava/net/URI;)Lorg/jboss/aerogear/android/unifiedpush/fcm/UnifiedPushConfig;", "")]
		public unsafe global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.UnifiedPushConfig SetPushServerURI (global::Java.Net.URI pushServerURI)
		{
			if (id_setPushServerURI_Ljava_net_URI_ == IntPtr.Zero)
				id_setPushServerURI_Ljava_net_URI_ = JNIEnv.GetMethodID (class_ref, "setPushServerURI", "(Ljava/net/URI;)Lorg/jboss/aerogear/android/unifiedpush/fcm/UnifiedPushConfig;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (pushServerURI);
				global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.UnifiedPushConfig __ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.UnifiedPushConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setPushServerURI_Ljava_net_URI_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setSecret_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.fcm']/class[@name='UnifiedPushConfig']/method[@name='setSecret' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setSecret", "(Ljava/lang/String;)Lorg/jboss/aerogear/android/unifiedpush/fcm/UnifiedPushConfig;", "")]
		public unsafe global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.UnifiedPushConfig SetSecret (string secret)
		{
			if (id_setSecret_Ljava_lang_String_ == IntPtr.Zero)
				id_setSecret_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSecret", "(Ljava/lang/String;)Lorg/jboss/aerogear/android/unifiedpush/fcm/UnifiedPushConfig;");
			IntPtr native_secret = JNIEnv.NewString (secret);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_secret);
				global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.UnifiedPushConfig __ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.UnifiedPushConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setSecret_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_secret);
			}
		}

		static IntPtr id_setSenderId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.fcm']/class[@name='UnifiedPushConfig']/method[@name='setSenderId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setSenderId", "(Ljava/lang/String;)Lorg/jboss/aerogear/android/unifiedpush/fcm/UnifiedPushConfig;", "")]
		public unsafe global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.UnifiedPushConfig SetSenderId (string senderId)
		{
			if (id_setSenderId_Ljava_lang_String_ == IntPtr.Zero)
				id_setSenderId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSenderId", "(Ljava/lang/String;)Lorg/jboss/aerogear/android/unifiedpush/fcm/UnifiedPushConfig;");
			IntPtr native_senderId = JNIEnv.NewString (senderId);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_senderId);
				global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.UnifiedPushConfig __ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.UnifiedPushConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setSenderId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_senderId);
			}
		}

		static IntPtr id_setVariantID_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.fcm']/class[@name='UnifiedPushConfig']/method[@name='setVariantID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setVariantID", "(Ljava/lang/String;)Lorg/jboss/aerogear/android/unifiedpush/fcm/UnifiedPushConfig;", "")]
		public unsafe global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.UnifiedPushConfig SetVariantID (string variantID)
		{
			if (id_setVariantID_Ljava_lang_String_ == IntPtr.Zero)
				id_setVariantID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setVariantID", "(Ljava/lang/String;)Lorg/jboss/aerogear/android/unifiedpush/fcm/UnifiedPushConfig;");
			IntPtr native_variantID = JNIEnv.NewString (variantID);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_variantID);
				global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.UnifiedPushConfig __ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Unifiedpush.Fcm.UnifiedPushConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setVariantID_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_variantID);
			}
		}

	}
}
