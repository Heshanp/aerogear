using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Unifiedpush.Fcm {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.fcm']/class[@name='AeroGearFCMPushConfiguration']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/unifiedpush/fcm/AeroGearFCMPushConfiguration", DoNotGenerateAcw=true)]
	public partial class AeroGearFCMPushConfiguration : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/unifiedpush/fcm/AeroGearFCMPushConfiguration", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AeroGearFCMPushConfiguration); }
		}

		protected AeroGearFCMPushConfiguration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
