using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Core.Reflection {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.core.reflection']/class[@name='Property']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/core/reflection/Property", DoNotGenerateAcw=true)]
	public partial class Property : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/core/reflection/Property", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Property); }
		}

		protected Property (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Class_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.core.reflection']/class[@name='Property']/constructor[@name='Property' and count(parameter)=2 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/Class;Ljava/lang/String;)V", "")]
		public unsafe Property (global::Java.Lang.Class p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (Property)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Class;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Class;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Class_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Class_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Class;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Class_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Class_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getFieldName;
#pragma warning disable 0169
		static Delegate GetGetFieldNameHandler ()
		{
			if (cb_getFieldName == null)
				cb_getFieldName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFieldName);
			return cb_getFieldName;
		}

		static IntPtr n_GetFieldName (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Core.Reflection.Property __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Core.Reflection.Property> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FieldName);
		}
#pragma warning restore 0169

		static IntPtr id_getFieldName;
		public virtual unsafe string FieldName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.core.reflection']/class[@name='Property']/method[@name='getFieldName' and count(parameter)=0]"
			[Register ("getFieldName", "()Ljava/lang/String;", "GetGetFieldNameHandler")]
			get {
				if (id_getFieldName == IntPtr.Zero)
					id_getFieldName = JNIEnv.GetMethodID (class_ref, "getFieldName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFieldName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFieldName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Core.Reflection.Property __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Core.Reflection.Property> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public virtual unsafe global::Java.Lang.Class Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.core.reflection']/class[@name='Property']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/Class;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Ljava/lang/Class;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Ljava/lang/Class;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getValue_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetValue_Ljava_lang_Object_Handler ()
		{
			if (cb_getValue_Ljava_lang_Object_ == null)
				cb_getValue_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetValue_Ljava_lang_Object_);
			return cb_getValue_Ljava_lang_Object_;
		}

		static IntPtr n_GetValue_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jboss.Aerogear.Android.Core.Reflection.Property __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Core.Reflection.Property> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetValue (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getValue_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.core.reflection']/class[@name='Property']/method[@name='getValue' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getValue", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetGetValue_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object GetValue (global::Java.Lang.Object p0)
		{
			if (id_getValue_Ljava_lang_Object_ == IntPtr.Zero)
				id_getValue_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getValue", "(Ljava/lang/Object;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValue_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue", "(Ljava/lang/Object;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setValue_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetValue_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_setValue_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_setValue_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetValue_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_setValue_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static void n_SetValue_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Jboss.Aerogear.Android.Core.Reflection.Property __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Core.Reflection.Property> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetValue (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setValue_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.core.reflection']/class[@name='Property']/method[@name='setValue' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register ("setValue", "(Ljava/lang/Object;Ljava/lang/Object;)V", "GetSetValue_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public virtual unsafe void SetValue (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			if (id_setValue_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_setValue_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setValue", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValue_Ljava_lang_Object_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValue", "(Ljava/lang/Object;Ljava/lang/Object;)V"), __args);
			} finally {
			}
		}

	}
}
