using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Core.Reflection {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.core.reflection']/class[@name='Scan']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/core/reflection/Scan", DoNotGenerateAcw=true)]
	public sealed partial class Scan : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/core/reflection/Scan", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Scan); }
		}

		internal Scan (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.core.reflection']/class[@name='Scan']/constructor[@name='Scan' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Scan ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Scan)) {
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

		static IntPtr id_findIdValueIn_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.core.reflection']/class[@name='Scan']/method[@name='findIdValueIn' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("findIdValueIn", "(Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static unsafe string FindIdValueIn (global::Java.Lang.Object p0)
		{
			if (id_findIdValueIn_Ljava_lang_Object_ == IntPtr.Zero)
				id_findIdValueIn_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "findIdValueIn", "(Ljava/lang/Object;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_findIdValueIn_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_recordIdFieldNameIn_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.core.reflection']/class[@name='Scan']/method[@name='recordIdFieldNameIn' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
		[Register ("recordIdFieldNameIn", "(Ljava/lang/Class;)Ljava/lang/String;", "")]
		public static unsafe string RecordIdFieldNameIn (global::Java.Lang.Class p0)
		{
			if (id_recordIdFieldNameIn_Ljava_lang_Class_ == IntPtr.Zero)
				id_recordIdFieldNameIn_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "recordIdFieldNameIn", "(Ljava/lang/Class;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_recordIdFieldNameIn_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
