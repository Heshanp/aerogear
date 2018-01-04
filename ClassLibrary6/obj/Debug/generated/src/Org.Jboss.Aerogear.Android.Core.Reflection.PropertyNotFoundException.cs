using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Core.Reflection {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.core.reflection']/class[@name='PropertyNotFoundException']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/core/reflection/PropertyNotFoundException", DoNotGenerateAcw=true)]
	public partial class PropertyNotFoundException : global::Java.Lang.RuntimeException {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/core/reflection/PropertyNotFoundException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PropertyNotFoundException); }
		}

		protected PropertyNotFoundException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.core.reflection']/class[@name='PropertyNotFoundException']/constructor[@name='PropertyNotFoundException' and count(parameter)=3 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='java.lang.Class'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/String;)V", "")]
		public unsafe PropertyNotFoundException (global::Java.Lang.Class klass, global::Java.Lang.Class type, string fieldName)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_fieldName = JNIEnv.NewString (fieldName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (klass);
				__args [1] = new JValue (type);
				__args [2] = new JValue (native_fieldName);
				if (((object) this).GetType () != typeof (PropertyNotFoundException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldName);
			}
		}

	}
}
