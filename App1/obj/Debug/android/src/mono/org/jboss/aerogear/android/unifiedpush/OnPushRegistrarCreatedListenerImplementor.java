package mono.org.jboss.aerogear.android.unifiedpush;


public class OnPushRegistrarCreatedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		org.jboss.aerogear.android.unifiedpush.OnPushRegistrarCreatedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onPushRegistrarCreated:(Lorg/jboss/aerogear/android/unifiedpush/PushConfiguration;Lorg/jboss/aerogear/android/unifiedpush/PushRegistrar;)V:GetOnPushRegistrarCreated_Lorg_jboss_aerogear_android_unifiedpush_PushConfiguration_Lorg_jboss_aerogear_android_unifiedpush_PushRegistrar_Handler:Org.Jboss.Aerogear.Android.Unifiedpush.IOnPushRegistrarCreatedListenerInvoker, ClassLibrary6\n" +
			"";
		mono.android.Runtime.register ("Org.Jboss.Aerogear.Android.Unifiedpush.IOnPushRegistrarCreatedListenerImplementor, ClassLibrary6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", OnPushRegistrarCreatedListenerImplementor.class, __md_methods);
	}


	public OnPushRegistrarCreatedListenerImplementor ()
	{
		super ();
		if (getClass () == OnPushRegistrarCreatedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Org.Jboss.Aerogear.Android.Unifiedpush.IOnPushRegistrarCreatedListenerImplementor, ClassLibrary6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onPushRegistrarCreated (org.jboss.aerogear.android.unifiedpush.PushConfiguration p0, org.jboss.aerogear.android.unifiedpush.PushRegistrar p1)
	{
		n_onPushRegistrarCreated (p0, p1);
	}

	private native void n_onPushRegistrarCreated (org.jboss.aerogear.android.unifiedpush.PushConfiguration p0, org.jboss.aerogear.android.unifiedpush.PushRegistrar p1);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
