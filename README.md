# Tool for showing all installed versions of .NET Core SDK

Add the following reference into your project:

```xml
   <DotNetCliToolReference Include="dotnet-allversions">
       <Version>0.1.1-*</Version>
   </DotNetCliToolReference>
```

###Usage:
```
dotnet allversions
```
###Output:
```
Installed .Net versions are:
Active version: 1.0.0-preview2

Product Information:
 Version:            1.0.0-preview1-002702
 Commit SHA-1 hash:  6cde2122

Product Information:
 Version:            1.0.0-preview2-003133
 Commit SHA-1 hash:  74df0650

Product Information:
 Version:            1.0.0-preview3-004056
 Commit SHA-1 hash:  ccc4968b

Product Information:
 Version:            1.0.0-preview4-004071
 Commit SHA-1 hash:  9855dc00

Runtime Environment:
 OS Name:     Windows
 OS Version:  10.0.14393
 OS Platform: Windows
 RID:         win10-x64
 ```

