using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Core.Reflection {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.core.reflection']/class[@name='FieldNotFoundException']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/core/reflection/FieldNotFoundException", DoNotGenerateAcw=true)]
	public partial class FieldNotFoundException : global::Java.Lang.RuntimeException {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/core/reflection/FieldNotFoundException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FieldNotFoundException); }
		}

		protected FieldNotFoundException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Class_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.core.reflection']/class[@name='FieldNotFoundException']/constructor[@name='FieldNotFoundException' and count(parameter)=2 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/Class;Ljava/lang/String;)V", "")]
		public unsafe FieldNotFoundException (global::Java.Lang.Class p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (FieldNotFoundException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Class;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Ljava/lang/Class;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Class_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Class_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Class;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Class_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Ljava_lang_Class_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
