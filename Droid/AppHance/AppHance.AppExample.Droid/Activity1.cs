using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
//using AppHance.PreProduction;
//using AppHance.PreProduction.Common;
//using AppHance.PreProduction.Device.Conditions;
using Com.Apphance.Android;
using Com.Apphance.Android.Common;

namespace AppHance.AppExample.Droid
{
    [Activity(Label = "Apphance", MainLauncher = true, Icon = "@drawable/apphance_icon")]
    public class Activity1 : Activity
    {
        int count = 1;
		public static string _appKey = "APIKey";


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Configuration configuration = new Configuration.Builder(this)
			.WithAPIKey(_appKey) //Provides Apphance APP_KEY
			//.WithMode(Apphance.Mode.Qa) //Selects Apphance mode
			//.WithUTestEnabled(true) //uTest integration switch enabled
			//.WithReportOnShakeEnabled(true) //Enables shake report trigger
			.Build();

            Apphance.StartNewSession(this, configuration);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }

        protected override void OnStart()
        {
            base.OnStart();
            Apphance.OnStart(this);
        }

        protected override void OnStop()
        {
            base.OnStop();
            Apphance.OnStop(this);
        }
    }
}

