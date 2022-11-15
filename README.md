# net7ca
Experiment to see if I can write Custom Actions in .NET 7.

TestMSI is a Wix4 installer which calls 2 custom actions.

CppCustomAction is a default sample C++ custom action. CustomAction is a .NET 7 Custom Action.

After compiling CustomAction it needs to be published with 

`dotnet publish /p:NativeLib=Shared -r win-x64 -c release`

Before building the TestMSI project, which reads it from the published location.
