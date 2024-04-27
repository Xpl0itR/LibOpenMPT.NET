LibOpenMPT.NET
==============
A mostly source-generated, blittable bindings library wrapping [libopenmpt](https://github.com/OpenMPT/openmpt) using [ClangSharp's PInvokeGenerator](https://github.com/dotnet/ClangSharp#Generating-Bindings) and [csbindgen's GroupedNativeMethodsGenerator](https://github.com/Cysharp/csbindgen#grouping-extension-methods), targeting .NET 8.0 and .NET Standard 2.0.

### Native libraries
By default, the included native libraries are copied to the build output directory, to disable this, add `ExcludeAssets="native"` to the `PackageReference` in your csproj.

The nuget package only includes native libraries for Windows x64, packages for other platforms can be found on the [OpenMPT wiki](https://wiki.openmpt.org/Libopenmpt#Distribution_packages).


Building
--------
Essentially just replicate the [CI instructions](.github/workflows/ci.yml).


Licensing
---------
This project is subject to the terms of the [Mozilla Public License, v. 2.0](./LICENSE).