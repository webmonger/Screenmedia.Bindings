using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using AppHance.PreProduction;

namespace AppHance.AppExample
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		public override UIWindow Window {
			get;
			set;
		}

		public override void FinishedLaunching (UIApplication application)
		{
			// NOTE: Don't call the base implementation on a Model class
			// see http://docs.xamarin.com/guides/ios/application_fundamentals/delegates,_protocols,_and_events

			// More work and maybe and extension for logging is required.

			APHLogger.StartNewSessionWithApplicationKey ("Insert App Key here");

			// If you do not have an Apphance application key, you must first create a free account.
			// Visit http://www.apphance.com for more information about how to create your account.
			//
			// If you already have an Apphance account, login to the Apphance control panel at: https://panel.apphance.com
			// Create a new application (if you have not done so already).
			// Your application key can be retrieved at any time from the "Settings" tab on the left menu.

			// For more Apphance help, visit http://help.apphance.com
			// For more help with Apphance on iOS, visit http://help.apphance.com/library-installation/ios/

			/***********************/
			/* End Apphance Config */
			/***********************/

			/********************************/
			/* Examples of Apphance Logging */
			/********************************/

			// The following lines are just examples - they are NOT necessary for configuration.
			//
			// Apphance allows you to log activities from within your application. The following lines of code are examples
			// of several different ways to log from within your application.
			//
			// You can use logging tools like these from anywhere within your app. In this example application, these methods
			// will write their log events when your app is started.

			/* APHLog */
			// This is the standard AppHance logging method. It works very similarly to NSLog. (You can even use this method
			// in place of NSLog - data sent to APHLog will still be logged to the console.)
			//APHLog(@"Example of APHLog", nil);

			// An example of the standard Apphance logging method with parameters.
			//APHLog(@"APHLog with a parameter: %@", @"demo parameter");

			/* APHExtendedLog */
			// Apphance also features an extended logging method that supports log levels and tags. (You can even use this method
			// in place of NSLog - data sent to APHExtendedLog will still be logged to the console.)
			// Here's an example of the extended logging method with a warning log level and no tags.
			APHLogger.LogWithLevel(APHLogLevel.Warning, "Tag 1", 0, "AppDelegate", "FinishedLaunching", new NSObject[0], "Some Other Text here");
			//APHExtendedLog(APHLogLevelWarning, nil, @"APHExtendedLog with a warning log level", nil);

			// Here's an example of the extended logging method with a verbose log level and a custom tag.
			//NSString *const tag = @"example_tag";
			//APHExtendedLog(APHLogLevelVerbose, tag, @"APHExtendedLog with a verbose log level and with tag: %@", tag);

			/* Object Logging */
			// Apphance can log messages received by objects. The following lines of code create a new
			// object with object logging enabled and then call an example method.
			//
			// Please see Supporting Files/UTLogObject.m for more details about how to enable object logging.
			//UTLogObject *testObject = [[UTLogObject alloc] init];
			//[testObject testMethod];

			// For more help with logging, visit http://help.apphance.com/library-installation/ios/logging

			/*********************************/
			/* End Apphance Logging Examples */
			/*********************************/
		}


		// The following line handles all uncaught exceptions and will send them to Apphance the next
		// time the application starts. Add this line to enable crash reporting.
		static void UncaughtExceptionHandler(IntPtr handle)
		{

			var exception = new NSException(handle);
			APHLogger.LogApplicationException (exception);

			Console.WriteLine(@"Got an exception...{0} -- {1}", exception.Name, exception.Reason);
		}

		// This method is invoked when the application is about to move from active to inactive state.
		// OpenGL applications should use this method to pause.
		public override void OnResignActivation (UIApplication application)
		{
		}
		// This method should be used to release shared resources and it should store the application state.
		// If your application supports background exection this method is called instead of WillTerminate
		// when the user quits.
		public override void DidEnterBackground (UIApplication application)
		{
		}
		// This method is called as part of the transiton from background to active state.
		public override void WillEnterForeground (UIApplication application)
		{
		}
		// This method is called when the application is about to terminate. Save data, if needed.
		public override void WillTerminate (UIApplication application)
		{
		}
	}
}

