using System;

using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;

namespace AppHance.PreProduction {

	[BaseType (typeof (NSObject))]
	public partial interface APHSettings {

		[Static, Export ("applicationId", ArgumentSemantic.Retain)]
		string ApplicationId { get; set; }

		[Static, Export ("applicationVersionName", ArgumentSemantic.Retain)]
		string ApplicationVersionName { get; set; }

		[Static, Export ("applicationVersionCode", ArgumentSemantic.Retain)]
		string ApplicationVersionCode { get; set; }

		[Static, Export ("defaultUser", ArgumentSemantic.Retain)]
		string DefaultUser { get; set; }

		[Static, Export ("reportOnShakeEnabled")]
		bool ReportOnShakeEnabled { [Bind ("isReportOnShakeEnabled")] get; set; }

		[Static, Export ("withUTest")]
		bool WithUTest { get; set; }

		[Static, Export ("screenShotsFromGallery")]
		bool ScreenShotsFromGallery { get; set; }

		[Static, Export ("machExceptionEnabled")]
		bool MachExceptionEnabled { [Bind ("isMathExceptionEnabled")] get; set; }

		[Static, Export ("serverURL", ArgumentSemantic.Retain)]
		string ServerURL { get; set; }

		[Static, Export ("apphanceMode")]
		APHSettingsMode ApphanceMode { get; set; }

		[Static, Export ("reportOnDoubleSlideEnabled")]
		bool ReportOnDoubleSlideEnabled { [Bind ("isReportOnDoubleSlideEnabled")] get; set; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface APHLogger {

		[Static, Export ("defaultSettings")]//, Verify ("ObjC method massaged into getter property", "/Users/jon/Documents/workspace/AppHance/Touch/Apphance-Production.framework/Versions/A/Headers/APHLogger.h", Line = 83)]
		APHSettings DefaultSettings { get; }

		[Static, Export ("startNewSessionWithApplicationKey:")]
		void StartNewSessionWithApplicationKey (string applicationId);

		[Static, Export ("logApplicationException:")]
		void LogApplicationException (NSException error);

		[Static, Export ("registerObjectForLogging:")]
		NSObject RegisterObjectForLogging (NSObject obj);

		[Static, Export ("flush")]
		void Flush ();

		[Static, Export ("showReportScreen")]
		void ShowReportScreen ();

		[Static, Export ("feedback:placeholder:")]
		void Feedback (string title, string placeholder);

		[Static, Export ("feedback:")]
		void Feedback (string title);

		[Static, Export ("feedback")]
		void Feedback ();

		[Static, Export ("sendFeedback:")]
		void SendFeedback (string feedback);
//	}
//
//	[Category, BaseType (typeof (APHLogger))]
//	public partial interface DeprecatedMethods_APHLogger {

//		[Static, Export ("startNewSessionWithApplicationKey:apphanceMode:withUtest:")]
//		void StartNewSessionWithApplicationKey (string applicationID, string apphanceMode, bool withUtest);
//
//		[Static, Export ("startNewSessionWithApplicationKey:apphanceMode:")]
//		void StartNewSessionWithApplicationKey (string applicationID, string apphanceMode);

//		[Static, Export ("reportOnShakeEnabled")]//, Verify ("ObjC method massaged into setter property", "/Users/jon/Documents/workspace/AppHance/Touch/Apphance-Production.framework/Versions/A/Headers/APHLogger.h", Line = 170)]
//		bool ReportOnShakeEnabled { set; }

//		[Static, Export ("reportOnDoubleSlideEnabled")]//, Verify ("ObjC method massaged into setter property", "/Users/jon/Documents/workspace/AppHance/Touch/Apphance-Production.framework/Versions/A/Headers/APHLogger.h", Line = 178)]
//		bool ReportOnDoubleSlideEnabled { set; }

//		[Static, Export ("versionName")]//, Verify ("ObjC method massaged into setter property", "/Users/jon/Documents/workspace/AppHance/Touch/Apphance-Production.framework/Versions/A/Headers/APHLogger.h", Line = 186)]
//		string VersionName { set; }
//
//		[Static, Export ("versionNumber")]//, Verify ("ObjC method massaged into setter property", "/Users/jon/Documents/workspace/AppHance/Touch/Apphance-Production.framework/Versions/A/Headers/APHLogger.h", Line = 194)]
//		string VersionNumber { set; }

//		[Static, Export ("defaultUser")]//, Verify ("ObjC method massaged into setter property", "/Users/jon/Documents/workspace/AppHance/Touch/Apphance-Production.framework/Versions/A/Headers/APHLogger.h", Line = 201)]
//		string DefaultUser { set; }
//	}
//
//	[Category, BaseType (typeof (APHLogger))]
//	public partial interface PrivateAccessors_APHLogger {
//
		[Static, Export ("logWithLevel:tag:line:fileName:method:stacktrace:format:")]
		void LogWithLevel (APHLogLevel level, string tag, int line, string fileName, string method, NSObject [] stacktrace, string format);
	}
}
