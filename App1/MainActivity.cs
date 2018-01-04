using System.Net;
using Android.App;
using Android.Widget;
using Android.OS;
using Java.Lang;
using Java.Net;
using Org.Jboss.Aerogear;
using Org.Jboss.Aerogear.Android.Unifiedpush;
using Org.Jboss.Aerogear.Android.Unifiedpush.Fcm;
using Org.Jboss.Aerogear.Android.Pipe;
using Org.Jboss.Aerogear.Android.Pipe.Rest;
using Org.Jboss.Aerogear.Android.Pipe.Util;

namespace App1
{
    [Activity(Label = "App1", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //PipeManager.Config("",null).WithUrl("").
            //var config = PipeManager.Config("lead", null).WithUrl().Module().Class
            //    .module(authenticationModule)
            //    .forClass(Lead.class);

            
            //IPushRegistrar registrar = RegistrarManager.GetRegistrar("AeroDoc");

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

