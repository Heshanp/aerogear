using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Unifiedpush.Fcm {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.fcm']/class[@name='AeroGearFCMPushJsonConfiguration']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/unifiedpush/fcm/AeroGearFCMPushJsonConfiguration", DoNotGenerateAcw=true)]
	public partial class AeroGearFCMPushJsonConfiguration : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/unifiedpush/fcm/AeroGearFCMPushJsonConfiguration", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AeroGearFCMPushJsonConfiguration); }
		}

		protected AeroGearFCMPushJsonConfiguration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
