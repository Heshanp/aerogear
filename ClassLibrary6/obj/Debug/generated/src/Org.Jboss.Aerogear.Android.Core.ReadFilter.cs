using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jboss.aerogear.android.core']/class[@name='ReadFilter']"
	[global::Android.Runtime.Register ("org/jboss/aerogear/android/core/ReadFilter", DoNotGenerateAcw=true)]
	public partial class ReadFilter : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jboss/aerogear/android/core/ReadFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ReadFilter); }
		}

		protected ReadFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jboss.aerogear.android.core']/class[@name='ReadFilter']/constructor[@name='ReadFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ReadFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ReadFilter)) {
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

		static Delegate cb_getLimit;
#pragma warning disable 0169
		static Delegate GetGetLimitHandler ()
		{
			if (cb_getLimit == null)
				cb_getLimit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLimit);
			return cb_getLimit;
		}

		static IntPtr n_GetLimit (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Core.ReadFilter __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Core.ReadFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Limit);
		}
#pragma warning restore 0169

		static Delegate cb_setLimit_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetLimit_Ljava_lang_Integer_Handler ()
		{
			if (cb_setLimit_Ljava_lang_Integer_ == null)
				cb_setLimit_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLimit_Ljava_lang_Integer_);
			return cb_setLimit_Ljava_lang_Integer_;
		}

		static void n_SetLimit_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_limit)
		{
			global::Org.Jboss.Aerogear.Android.Core.ReadFilter __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Core.ReadFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer limit = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_limit, JniHandleOwnership.DoNotTransfer);
			__this.Limit = limit;
		}
#pragma warning restore 0169

		static IntPtr id_getLimit;
		static IntPtr id_setLimit_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer Limit {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.core']/class[@name='ReadFilter']/method[@name='getLimit' and count(parameter)=0]"
			[Register ("getLimit", "()Ljava/lang/Integer;", "GetGetLimitHandler")]
			get {
				if (id_getLimit == IntPtr.Zero)
					id_getLimit = JNIEnv.GetMethodID (class_ref, "getLimit", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLimit), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLimit", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.core']/class[@name='ReadFilter']/method[@name='setLimit' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setLimit", "(Ljava/lang/Integer;)V", "GetSetLimit_Ljava_lang_Integer_Handler")]
			set {
				if (id_setLimit_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setLimit_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setLimit", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLimit_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLimit", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLinkUri;
#pragma warning disable 0169
		static Delegate GetGetLinkUriHandler ()
		{
			if (cb_getLinkUri == null)
				cb_getLinkUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLinkUri);
			return cb_getLinkUri;
		}

		static IntPtr n_GetLinkUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Core.ReadFilter __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Core.ReadFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LinkUri);
		}
#pragma warning restore 0169

		static Delegate cb_setLinkUri_Ljava_net_URI_;
#pragma warning disable 0169
		static Delegate GetSetLinkUri_Ljava_net_URI_Handler ()
		{
			if (cb_setLinkUri_Ljava_net_URI_ == null)
				cb_setLinkUri_Ljava_net_URI_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLinkUri_Ljava_net_URI_);
			return cb_setLinkUri_Ljava_net_URI_;
		}

		static void n_SetLinkUri_Ljava_net_URI_ (IntPtr jnienv, IntPtr native__this, IntPtr native_linkUri)
		{
			global::Org.Jboss.Aerogear.Android.Core.ReadFilter __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Core.ReadFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.URI linkUri = global::Java.Lang.Object.GetObject<global::Java.Net.URI> (native_linkUri, JniHandleOwnership.DoNotTransfer);
			__this.LinkUri = linkUri;
		}
#pragma warning restore 0169

		static IntPtr id_getLinkUri;
		static IntPtr id_setLinkUri_Ljava_net_URI_;
		public virtual unsafe global::Java.Net.URI LinkUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.core']/class[@name='ReadFilter']/method[@name='getLinkUri' and count(parameter)=0]"
			[Register ("getLinkUri", "()Ljava/net/URI;", "GetGetLinkUriHandler")]
			get {
				if (id_getLinkUri == IntPtr.Zero)
					id_getLinkUri = JNIEnv.GetMethodID (class_ref, "getLinkUri", "()Ljava/net/URI;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Net.URI> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLinkUri), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Net.URI> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLinkUri", "()Ljava/net/URI;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.core']/class[@name='ReadFilter']/method[@name='setLinkUri' and count(parameter)=1 and parameter[1][@type='java.net.URI']]"
			[Register ("setLinkUri", "(Ljava/net/URI;)V", "GetSetLinkUri_Ljava_net_URI_Handler")]
			set {
				if (id_setLinkUri_Ljava_net_URI_ == IntPtr.Zero)
					id_setLinkUri_Ljava_net_URI_ = JNIEnv.GetMethodID (class_ref, "setLinkUri", "(Ljava/net/URI;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLinkUri_Ljava_net_URI_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLinkUri", "(Ljava/net/URI;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOffset;
#pragma warning disable 0169
		static Delegate GetGetOffsetHandler ()
		{
			if (cb_getOffset == null)
				cb_getOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOffset);
			return cb_getOffset;
		}

		static IntPtr n_GetOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Core.ReadFilter __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Core.ReadFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Offset);
		}
#pragma warning restore 0169

		static Delegate cb_setOffset_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetOffset_Ljava_lang_Integer_Handler ()
		{
			if (cb_setOffset_Ljava_lang_Integer_ == null)
				cb_setOffset_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOffset_Ljava_lang_Integer_);
			return cb_setOffset_Ljava_lang_Integer_;
		}

		static void n_SetOffset_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_offset)
		{
			global::Org.Jboss.Aerogear.Android.Core.ReadFilter __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Core.ReadFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer offset = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_offset, JniHandleOwnership.DoNotTransfer);
			__this.Offset = offset;
		}
#pragma warning restore 0169

		static IntPtr id_getOffset;
		static IntPtr id_setOffset_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer Offset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.core']/class[@name='ReadFilter']/method[@name='getOffset' and count(parameter)=0]"
			[Register ("getOffset", "()Ljava/lang/Integer;", "GetGetOffsetHandler")]
			get {
				if (id_getOffset == IntPtr.Zero)
					id_getOffset = JNIEnv.GetMethodID (class_ref, "getOffset", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOffset), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOffset", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.core']/class[@name='ReadFilter']/method[@name='setOffset' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setOffset", "(Ljava/lang/Integer;)V", "GetSetOffset_Ljava_lang_Integer_Handler")]
			set {
				if (id_setOffset_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setOffset_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setOffset", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOffset_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOffset", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getQuery;
#pragma warning disable 0169
		static Delegate GetGetQueryHandler ()
		{
			if (cb_getQuery == null)
				cb_getQuery = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetQuery);
			return cb_getQuery;
		}

		static IntPtr n_GetQuery (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Core.ReadFilter __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Core.ReadFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Query);
		}
#pragma warning restore 0169

		static IntPtr id_getQuery;
		public virtual unsafe string Query {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.core']/class[@name='ReadFilter']/method[@name='getQuery' and count(parameter)=0]"
			[Register ("getQuery", "()Ljava/lang/String;", "GetGetQueryHandler")]
			get {
				if (id_getQuery == IntPtr.Zero)
					id_getQuery = JNIEnv.GetMethodID (class_ref, "getQuery", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getQuery), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getQuery", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getWhere;
#pragma warning disable 0169
		static Delegate GetGetWhereHandler ()
		{
			if (cb_getWhere == null)
				cb_getWhere = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWhere);
			return cb_getWhere;
		}

		static IntPtr n_GetWhere (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jboss.Aerogear.Android.Core.ReadFilter __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Core.ReadFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Where);
		}
#pragma warning restore 0169

		static Delegate cb_setWhere_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetSetWhere_Lorg_json_JSONObject_Handler ()
		{
			if (cb_setWhere_Lorg_json_JSONObject_ == null)
				cb_setWhere_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetWhere_Lorg_json_JSONObject_);
			return cb_setWhere_Lorg_json_JSONObject_;
		}

		static void n_SetWhere_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native__where)
		{
			global::Org.Jboss.Aerogear.Android.Core.ReadFilter __this = global::Java.Lang.Object.GetObject<global::Org.Jboss.Aerogear.Android.Core.ReadFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject @where = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native__where, JniHandleOwnership.DoNotTransfer);
			__this.Where = @where;
		}
#pragma warning restore 0169

		static IntPtr id_getWhere;
		static IntPtr id_setWhere_Lorg_json_JSONObject_;
		public virtual unsafe global::Org.Json.JSONObject Where {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.core']/class[@name='ReadFilter']/method[@name='getWhere' and count(parameter)=0]"
			[Register ("getWhere", "()Lorg/json/JSONObject;", "GetGetWhereHandler")]
			get {
				if (id_getWhere == IntPtr.Zero)
					id_getWhere = JNIEnv.GetMethodID (class_ref, "getWhere", "()Lorg/json/JSONObject;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getWhere), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWhere", "()Lorg/json/JSONObject;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jboss.aerogear.android.core']/class[@name='ReadFilter']/method[@name='setWhere' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register ("setWhere", "(Lorg/json/JSONObject;)V", "GetSetWhere_Lorg_json_JSONObject_Handler")]
			set {
				if (id_setWhere_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_setWhere_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "setWhere", "(Lorg/json/JSONObject;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setWhere_Lorg_json_JSONObject_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWhere", "(Lorg/json/JSONObject;)V"), __args);
				} finally {
				}
			}
		}

	}
}
