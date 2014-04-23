using System;

using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;

namespace Screenmedia.Bindings.Touch.AppHance.PreProduction {

	[BaseType (typeof (NSObject))]
	public partial interface APHSettings {

		[Export ("applicationId", ArgumentSemantic.Retain)]
		string ApplicationId { get; set; }

		[Export ("applicationVersionName", ArgumentSemantic.Retain)]
		string ApplicationVersionName { get; set; }

		[Export ("applicationVersionCode", ArgumentSemantic.Retain)]
		string ApplicationVersionCode { get; set; }

		[Export ("defaultUser", ArgumentSemantic.Retain)]
		string DefaultUser { get; set; }

		[Export ("reportOnShakeEnabled")]
		bool ReportOnShakeEnabled { [Bind ("isReportOnShakeEnabled")] get; set; }

		[Export ("withUTest")]
		bool WithUTest { get; set; }

		[Export ("screenShotsFromGallery")]
		bool ScreenShotsFromGallery { get; set; }

		[Export ("machExceptionEnabled")]
		bool MachExceptionEnabled { [Bind ("isMathExceptionEnabled")] get; set; }

		[Export ("serverURL", ArgumentSemantic.Retain)]
		string ServerURL { get; set; }

		[Export ("apphanceMode")]
		APHSettingsMode ApphanceMode { get; set; }

		[Export ("reportOnDoubleSlideEnabled")]
		bool ReportOnDoubleSlideEnabled { [Bind ("isReportOnDoubleSlideEnabled")] get; set; }
	}



	[BaseType (typeof (NSObject))]
	public partial interface APHLogger {

		[Static, Export ("defaultSettings")]
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
	}

	[Category, BaseType (typeof (APHLogger))]
	public partial interface DeprecatedMethods_APHLogger {

		[Static, Export ("startNewSessionWithApplicationKey:apphanceMode:withUtest:")]
		void StartNewSessionWithApplicationKey (string applicationID, string apphanceMode, bool withUtest);

		[Static, Export ("startNewSessionWithApplicationKey:apphanceMode:")]
		void StartNewSessionWithApplicationKey (string applicationID, string apphanceMode);

		[Static, Export ("reportOnShakeEnabled")]
		bool ReportOnShakeEnabled { set; }

		[Static, Export ("reportOnDoubleSlideEnabled")]
		bool ReportOnDoubleSlideEnabled { set; }

		[Static, Export ("versionName")]
		string VersionName { set; }

		[Static, Export ("versionNumber")]
		string VersionNumber { set; }

		[Static, Export ("defaultUser")]
		string DefaultUser { set; }
	}

	[Category, BaseType (typeof (APHLogger))]
	public partial interface PrivateAccessors_APHLogger {

		[Static, Export ("logWithLevel:tag:line:fileName:method:stacktrace:format:")]
		void LogWithLevel (APHLogLevel level, string tag, int line, string fileName, string method, NSObject [] stacktrace, string format);
	}
}
