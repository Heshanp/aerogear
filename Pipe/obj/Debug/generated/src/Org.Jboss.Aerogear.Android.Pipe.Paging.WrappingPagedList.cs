using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Pipe.Paging {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.paging']/class[@name='WrappingPagedList']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/paging/WrappingPagedList", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class WrappingPagedList : global::Java.Util.ArrayList {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/pipe/paging/WrappingPagedList", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WrappingPagedList); }
		}

		protected WrappingPagedList (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
