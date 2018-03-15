using System;
using ObjCRuntime;

[assembly: LinkWith ("MAMapKit.a", 
    LinkTarget.ArmV7 | LinkTarget.Simulator,
    Frameworks = "GLKit OpenGLES UIKit Foundation CoreGraphics QuartzCore CoreLocation CoreTelephony SystemConfiguration Security AdSupport JavaScriptCore",
    LinkerFlags = "-lz -lstdc++ -lc++",
    ForceLoad = true)]
