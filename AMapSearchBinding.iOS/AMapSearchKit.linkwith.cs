using System;
using ObjCRuntime;

[assembly: LinkWith ("AMapSearchKit.a", LinkTarget.ArmV7 | LinkTarget.Simulator, ForceLoad = true)]
