using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Pipe.Paging {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.paging']/interface[@name='MetadataLocation']"
	[Register ("org/jboss/aerogear/android/pipe/paging/MetadataLocation", "", "Org.Jboss.Aerogear.Android.Pipe.Paging.IMetadataLocationInvoker")]
	public partial interface IMetadataLocation : IJavaObject {

	}

	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/paging/MetadataLocation", DoNotGenerateAcw=true)]
	internal class IMetadataLocationInvoker : global::Java.Lang.Object, IMetadataLocation {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/jboss/aerogear/android/pipe/paging/MetadataLocation");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMetadataLocationInvoker); }
		}

		IntPtr class_ref;

		public static IMetadataLocation GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMetadataLocation> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.jboss.aerogear.android.pipe.paging.MetadataLocation"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMetadataLocationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

}
