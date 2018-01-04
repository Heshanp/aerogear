using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Pipe {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.pipe']/class[@name='PipeManager']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/PipeManager", DoNotGenerateAcw=true)]
	public partial class PipeManager : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/pipe/PipeManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PipeManager); }
		}

		protected PipeManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_config_Ljava_lang_String_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.pipe']/class[@name='PipeManager']/method[@name='config' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class&lt;CFG&gt;']]"
		[Register ("config", "(Ljava/lang/String;Ljava/lang/Class;)Lorg/jboss/aerogear/android/pipe/PipeConfiguration;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"CFG extends org.jboss.aerogear.android.pipe.PipeConfiguration<CFG>"})]
		public static unsafe global::Org.Jboss.Aerogear.Android.Pipe.PipeConfiguration Config (string p0, global::Java.Lang.Class p1)
		{
			if (id_config_Ljava_lang_String_Ljava_lang_Class_ == IntPtr.Zero)
				id_config_Ljava_lang_String_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "config", "(Ljava/lang/String;Ljava/lang/Class;)Lorg/jboss/aerogear/android/pipe/PipeConfiguration;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Org.Jboss.Aerogear.Android.Pipe.PipeConfiguration __ret = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Pipe.PipeConfiguration> (JNIEnv.CallStaticObjectMethod  (class_ref, id_config_Ljava_lang_String_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
