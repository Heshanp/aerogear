using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Core.Reflection {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.core.reflection']/class[@name='RecordIdNotFoundException']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/core/reflection/RecordIdNotFoundException", DoNotGenerateAcw=true)]
	public partial class RecordIdNotFoundException : global::Java.Lang.RuntimeException {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/core/reflection/RecordIdNotFoundException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RecordIdNotFoundException); }
		}

		protected RecordIdNotFoundException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Class_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.core.reflection']/class[@name='RecordIdNotFoundException']/constructor[@name='RecordIdNotFoundException' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
		[Register (".ctor", "(Ljava/lang/Class;)V", "")]
		public unsafe RecordIdNotFoundException (global::Java.Lang.Class p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (RecordIdNotFoundException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Class;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Ljava/lang/Class;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Class_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Class;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Class_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Ljava_lang_Class_, __args);
			} finally {
			}
		}

	}
}
