# ReflectionExample

There are 4 projects in this solution

* Console.exe
Displays the message of the class loaded via reflection

* assemblyCommon.dll
Contains a common interface implemented by classes loaded via reflection

* assemblyA.dll
Assembly loaded via reflection that talks trash about assemblyB.dll

* assemblyB.dll
Assembly loaded via reflection that talks trash about assemblyA.dll


Change <absolute_path_to> in appSettings.json and then run the app

Change "WhichAssemblyConfiguration" in appSettings.json from "AssemblyB" to "AssemblyA" and observe how the output of the Console app changes.
