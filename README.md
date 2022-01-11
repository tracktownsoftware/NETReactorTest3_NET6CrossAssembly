# NETReactorTest3_NET6CrossAssembly

Possible obfuscation issue where NET Reactor v6.8.0.0 doesn’t rename explicit interface implementations correctly for cross assembly obfuscation. 
- Folder Output_NoObfuscation contains non-obfuscated assemblies. Run ConsoleTestApp.exe to see how it should behave.
- Folder Output_NETReactor contains obfusacted assemblies. Run ConsoleTestApp.exe to see exception caused by obfuscation bug.

The NET reactor project file is ConsoleTestApp.nrproj
- All My.* input assemblies contain internal types
- Ignore InternalsVisibleTo is checked because I want all internal types and members obfuscated 
