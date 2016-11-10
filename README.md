# Tool for showing all installed versions of .NET Core SDK

Add the following reference into your project:

```xml
   <DotNetCliToolReference Include="dotnet-allversions">
       <Version>0.1.1-*</Version>
   </DotNetCliToolReference>
```

Usage:

```dotnet allversions```


