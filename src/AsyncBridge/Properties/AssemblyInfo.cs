﻿using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Daniel Grunwald,Omer Mor,Alex Davies")]
[assembly: AssemblyProduct("AsyncBridge")]
[assembly: AssemblyCopyright("Copyright ©  2012")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

#if !PORTABLE
// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("4c92b8ab-efb0-49a2-b9c7-7f98e9f351eb")]
#endif

// Version information for an assembly consists of the following three values (SemVer compatible):
//
//      Major.Minor.Patch.
// In brief, these correspond to: 
//      Major: Breaking changes.
//      Minor: New features, but backwards compatible.
//      Patch: Backwards compatible bug fixes only.
//
[assembly: AssemblyVersion("0.2.3333.0")] // only increment major (breaking changes)
[assembly: AssemblyFileVersion(Metadata.Version)]
[assembly: AssemblyInformationalVersion(Metadata.Version)]
 
internal class Metadata
{
    internal const string Version = "0.2.3333.0";
}