using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Unifiedpush {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush']/interface[@name='OnPushRegistrarCreatedListener']"
	[Register ("org/jboss/aerogear/android/unifiedpush/OnPushRegistrarCreatedListener", "", "Org.Jboss.Aerogear.Android.Unifiedpush.IOnPushRegistrarCreatedListenerInvoker")]
	public partial interface IOnPushRegistrarCreatedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush']/interface[@name='OnPushRegistrarCreatedListener']/method[@name='onPushRegistrarCreated' and count(parameter)=2 and parameter[1][@type='org.jboss.aerogear.android.unifiedpush.PushConfiguration&lt;?&gt;'] and parameter[2][@type='org.jboss.aerogear.android.unifiedpush.PushRegistrar']]"
		[Register ("onPushRegistrarCreated", "(Lorg/jboss/aerogear/android/unifiedpush/PushConfiguration;Lorg/jboss/aerogear/android/unifiedpush/PushRegistrar;)V", "GetOnPushRegistrarCreated_Lorg_jboss_aerogear_android_unifiedpush_PushConfiguration_Lorg_jboss_aerogear_android_unifiedpush_PushRegistrar_Handler:Org.Jboss.Aerogear.Android.Unifiedpush.IOnPushRegistrarCreatedListenerInvoker, ClassLibrary6")]
		void OnPushRegistrarCreated (global::Org.Jboss.Aerogear.Android.Unifiedpush.PushConfiguration p0, global::Org.Jboss.Aerogear.Android.Unifiedpush.IPushRegistrar p1);

	}

	[global::Android.Runtime.Register ("org/jboss/aerogear/android/unifiedpush/OnPushRegistrarCreatedListener", DoNotGenerateAcw=true)]
	internal class IOnPushRegistrarCreatedListenerInvoker : global::Java.Lang.Object, IOnPushRegistrarCreatedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/jboss/aerogear/android/unifiedpush/OnPushRegistrarCreatedListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOnPushRegistrarCreatedListenerInvoker); }
		}

		IntPtr class_ref;

		public static IOnPushRegistrarCreatedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnPushRegistrarCreatedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.jboss.aerogear.android.unifiedpush.OnPushRegistrarCreatedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnPushRegistrarCreatedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onPushRegistrarCreated_Lorg_jboss_aerogear_android_unifiedpush_PushConfiguration_Lorg_jboss_aerogear_android_unifiedpush_PushRegistrar_;
#pragma warning disable 0169
		static Delegate GetOnPushRegistrarCreated_Lorg_jboss_aerogear_android_unifiedpush_PushConfiguration_Lorg_jboss_aerogear_android_unifiedpush_PushRegistrar_Handler ()
		{
			if (cb_onPushRegistrarCreated_Lorg_jboss_aerogear_android_unifiedpush_PushConfiguration_Lorg_jboss_aerogear_android_unifiedpush_PushRegistrar_ == null)
				cb_onPushRegistrarCreated_Lorg_jboss_aerogear_android_unifiedpush_PushConfiguration_Lorg_jboss_aerogear_android_unifiedpush_PushRegistrar_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnPushRegistrarCreated_Lorg_jboss_aerogear_android_unifiedpush_PushConfiguration_Lorg_jboss_aerogear_android_unifiedpush_PushRegistrar_);
			return cb_onPushRegistrarCreated_Lorg_jboss_aerogear_android_unifiedpush_PushConfiguration_Lorg_jboss_aerogear_android_unifiedpush_PushRegistrar_;
		}

		static void n_OnPushRegistrarCreated_Lorg_jboss_aerogear_android_unifiedpush_PushConfiguration_Lorg_jboss_aerogear_android_unifiedpush_PushRegistrar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Jboss.Aerogear.Android.Unifiedpush.IOnPushRegistrarCreatedListener __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Unifiedpush.IOnPushRegistrarCreatedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jboss.Aerogear.Android.Unifiedpush.PushConfiguration p0 = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Unifiedpush.PushConfiguration> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Jboss.Aerogear.Android.Unifiedpush.IPushRegistrar p1 = (global::Org.Jboss.Aerogear.Android.Unifiedpush.IPushRegistrar)global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Unifiedpush.IPushRegistrar> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnPushRegistrarCreated (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onPushRegistrarCreated_Lorg_jboss_aerogear_android_unifiedpush_PushConfiguration_Lorg_jboss_aerogear_android_unifiedpush_PushRegistrar_;
		public unsafe void OnPushRegistrarCreated (global::Org.Jboss.Aerogear.Android.Unifiedpush.PushConfiguration p0, global::Org.Jboss.Aerogear.Android.Unifiedpush.IPushRegistrar p1)
		{
			if (id_onPushRegistrarCreated_Lorg_jboss_aerogear_android_unifiedpush_PushConfiguration_Lorg_jboss_aerogear_android_unifiedpush_PushRegistrar_ == IntPtr.Zero)
				id_onPushRegistrarCreated_Lorg_jboss_aerogear_android_unifiedpush_PushConfiguration_Lorg_jboss_aerogear_android_unifiedpush_PushRegistrar_ = JNIEnv.GetMethodID (class_ref, "onPushRegistrarCreated", "(Lorg/jboss/aerogear/android/unifiedpush/PushConfiguration;Lorg/jboss/aerogear/android/unifiedpush/PushRegistrar;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPushRegistrarCreated_Lorg_jboss_aerogear_android_unifiedpush_PushConfiguration_Lorg_jboss_aerogear_android_unifiedpush_PushRegistrar_, __args);
		}

	}

	public partial class PushRegistrarCreatedEventArgs : global::System.EventArgs {

		public PushRegistrarCreatedEventArgs (global::Org.Jboss.Aerogear.Android.Unifiedpush.PushConfiguration p0, global::Org.Jboss.Aerogear.Android.Unifiedpush.IPushRegistrar p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Org.Jboss.Aerogear.Android.Unifiedpush.PushConfiguration p0;
		public global::Org.Jboss.Aerogear.Android.Unifiedpush.PushConfiguration P0 {
			get { return p0; }
		}

		global::Org.Jboss.Aerogear.Android.Unifiedpush.IPushRegistrar p1;
		public global::Org.Jboss.Aerogear.Android.Unifiedpush.IPushRegistrar P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/org/jboss/aerogear/android/unifiedpush/OnPushRegistrarCreatedListenerImplementor")]
	internal sealed partial class IOnPushRegistrarCreatedListenerImplementor : global::Java.Lang.Object, IOnPushRegistrarCreatedListener {

		object sender;

		public IOnPushRegistrarCreatedListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/org/jboss/aerogear/android/unifiedpush/OnPushRegistrarCreatedListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<PushRegistrarCreatedEventArgs> Handler;
#pragma warning restore 0649

		public void OnPushRegistrarCreated (global::Org.Jboss.Aerogear.Android.Unifiedpush.PushConfiguration p0, global::Org.Jboss.Aerogear.Android.Unifiedpush.IPushRegistrar p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new PushRegistrarCreatedEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IOnPushRegistrarCreatedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
