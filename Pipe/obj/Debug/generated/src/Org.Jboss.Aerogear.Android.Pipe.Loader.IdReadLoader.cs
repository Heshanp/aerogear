using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Pipe.Loader {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.loader']/class[@name='IdReadLoader']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/loader/IdReadLoader", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class IdReadLoader : global::Org.Jboss.Aerogear.Android.Pipe.Loader.ReadLoader {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/pipe/loader/IdReadLoader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IdReadLoader); }
		}

		protected IdReadLoader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
