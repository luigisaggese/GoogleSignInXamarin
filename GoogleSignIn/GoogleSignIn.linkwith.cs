using System;
using ObjCRuntime;

[assembly: LinkWith ("GoogleSignIn", LinkTarget.ArmV7 | LinkTarget.Simulator | LinkTarget.Simulator64 | LinkTarget.Arm64, LinkerFlags = "-ObjC -fobjc-arc", Frameworks="SystemConfiguration Security AddressBook", SmartLink = true, ForceLoad = true)]
