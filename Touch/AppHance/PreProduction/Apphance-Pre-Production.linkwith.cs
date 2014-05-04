using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("Apphance-Pre-Production.a", LinkTarget.Arm64 | LinkTarget.ArmV7s | LinkTarget.Simulator, ForceLoad = true)]
