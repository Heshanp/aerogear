using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Pipe.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.util']/class[@name='ClassUtils']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/util/ClassUtils", DoNotGenerateAcw=true)]
	public partial class ClassUtils : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/pipe/util/ClassUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ClassUtils); }
		}

		protected ClassUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.util']/class[@name='ClassUtils']/constructor[@name='ClassUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ClassUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ClassUtils)) {
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

		static IntPtr id_asArrayClass_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.util']/class[@name='ClassUtils']/method[@name='asArrayClass' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("asArrayClass", "(Ljava/lang/Class;)Ljava/lang/Class;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Class AsArrayClass (global::Java.Lang.Class p0)
		{
			if (id_asArrayClass_Ljava_lang_Class_ == IntPtr.Zero)
				id_asArrayClass_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "asArrayClass", "(Ljava/lang/Class;)Ljava/lang/Class;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.Lang.Class __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallStaticObjectMethod  (class_ref, id_asArrayClass_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
