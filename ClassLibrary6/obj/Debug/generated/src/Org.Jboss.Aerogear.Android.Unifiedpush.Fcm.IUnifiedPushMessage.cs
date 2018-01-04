using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jboss.Aerogear.Android.Unifiedpush.Fcm {

	[Register ("org/jboss/aerogear/android/unifiedpush/fcm/UnifiedPushMessage", DoNotGenerateAcw=true)]
	public abstract class UnifiedPushMessage : Java.Lang.Object {

		internal UnifiedPushMessage ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.fcm']/interface[@name='UnifiedPushMessage']/field[@name='ALERT_KEY']"
		[Register ("ALERT_KEY")]
		public const string AlertKey = (string) "alert";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jboss.aerogear.android.unifiedpush.fcm']/interface[@name='UnifiedPushMessage']/field[@name='PUSH_MESSAGE_ID']"
		[Register ("PUSH_MESSAGE_ID")]
		public const string PushMessageId = (string) "aerogear-push-id";
	}

	[Register ("org/jboss/aerogear/android/unifiedpush/fcm/UnifiedPushMessage", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'UnifiedPushMessage' type. This type will be removed in a future release.")]
	public abstract class UnifiedPushMessageConsts : UnifiedPushMessage {

		private UnifiedPushMessageConsts ()
		{
		}
	}

}
