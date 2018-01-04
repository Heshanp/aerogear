using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Pipe.Paging {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.paging']/class[@name='URIBodyPageParser']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/pipe/paging/URIBodyPageParser", DoNotGenerateAcw=true)]
	public partial class URIBodyPageParser : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/pipe/paging/URIBodyPageParser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (URIBodyPageParser); }
		}

		protected URIBodyPageParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.paging']/class[@name='URIBodyPageParser']/constructor[@name='URIBodyPageParser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe URIBodyPageParser ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (URIBodyPageParser)) {
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

		static IntPtr id_ctor_Ljava_net_URL_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.paging']/class[@name='URIBodyPageParser']/constructor[@name='URIBodyPageParser' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
		[Register (".ctor", "(Ljava/net/URL;)V", "")]
		public unsafe URIBodyPageParser (global::Java.Net.URL p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (URIBodyPageParser)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/net/URL;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/net/URL;)V", __args);
					return;
				}

				if (id_ctor_Ljava_net_URL_ == IntPtr.Zero)
					id_ctor_Ljava_net_URL_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/net/URL;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_net_URL_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_net_URL_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_net_URI_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.pipe.paging']/class[@name='URIBodyPageParser']/constructor[@name='URIBodyPageParser' and count(parameter)=1 and parameter[1][@type='java.net.URI']]"
		[Register (".ctor", "(Ljava/net/URI;)V", "")]
		public unsafe URIBodyPageParser (global::Java.Net.URI p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (URIBodyPageParser)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/net/URI;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/net/URI;)V", __args);
					return;
				}

				if (id_ctor_Ljava_net_URI_ == IntPtr.Zero)
					id_ctor_Ljava_net_URI_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/net/URI;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_net_URI_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_net_URI_, __args);
			} finally {
			}
		}

	}
}
