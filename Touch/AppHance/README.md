# Xamarin Binding for AppHance 

This binding is setup to work with the Pre-Production Library however it should work with the Production Library too.

You can download the iOS SDK from here https://help.apphance.com/library-installation/ios

Once downloaded extract the files, add .a to the file named Apphance-Pre-Production making is Apphance-Pre-Production.a then copy this file to the PreProduction folder.

Include the project reference in your project and make sure you follow these important steps.

## Very important

In your iOS project (the one you're building to your phone) right click on the project and select Options > iOS Build > Additional options

Paste the following in to the text box
> -gcc_flags "-force_load ${ProjectDir}/../PreProduction/Apphance-Pre-Production.a -framework AssetsLibrary -framework CoreLocation -framework AudioToolbox -framework CoreGraphics -framework CoreText -framework Foundation -framework QuartzCore -framework Security -framework SystemConfiguration -framework UIKit"

Change the URI _/../PreProduction/Apphance-Pre-Production.a_ to the relative path from your iOS project to the AppHance binding. Alternatively copy the _Apphance-Pre-Production.a_ file to the root of your iOS project and use this string _${ProjectDir}/Apphance-Pre-Production.a_

