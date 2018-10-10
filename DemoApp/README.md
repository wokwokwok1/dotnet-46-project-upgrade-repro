# Steps taken

This follows on from the branch `net472_003_manualDependencyResolution`

## summary

Automatic upgrading using retargeting has failed.

Manually migrating to use package references has failed.

Manually updating package versions has failed.

Application compiles without error, but at runtime we see:

    Compiler Error Message: CS0012: The type 'System.Object' is defined in an assembly that is not referenced. You must add a reference to assembly 'System.Runtime, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'.

We will now attempt to simply upgrade everything to the latest possible version.

There's no particular reason to expect this to work, but we've tried pretty much everything else at this point.

## steps

- upgrade all dependencies
- rebuild

## errors

    Server Error in '/' Application.
    Compilation Error
    Description: An error occurred during the compilation of a resource required to service this request. Please review the following specific error details and modify your source code appropriately. 

    Compiler Error Message: CS0012: The type 'System.Object' is defined in an assembly that is not referenced. You must add a reference to assembly 'netstandard, Version=2.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'.

    Source Error:


    Line 17:                     <span class="icon-bar"></span>
    Line 18:                 </button>
    Line 19:                 @Html.ActionLink("Application name", "Index", "Home", new { area = "" }, new { @class = "navbar-brand" })
    Line 20:             </div>
    Line 21:             <div class="navbar-collapse collapse">

    Source File: c:\projects\3rdparty\migrateProject\DemoApp\DemoApp\Views\Shared\_Layout.cshtml    Line: 19 


    Show Detailed Compiler Output:

    Show Complete Compilation Source:


    Version Information: Microsoft .NET Framework Version:4.0.30319; ASP.NET Version:4.7.3160.0

## steps

- Update `web.config` as per https://github.com/dotnet/standard/issues/542:

    <system.web>
      <compilation debug="true" targetFramework="4.7.2">
        <assemblies>
          <add assembly="netstandard, Version=2.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51"/>
        </assemblies>
      </compilation>
      <httpRuntime targetFramework="4.7.2"/>
      <httpModules/>
    </system.web>

- rebuild, etc.

## errors

    Server Error in '/' Application.
    Compilation Error
    Description: An error occurred during the compilation of a resource required to service this request. Please review the following specific error details and modify your source code appropriately. 

    Compiler Error Message: CS0012: The type 'System.Object' is defined in an assembly that is not referenced. You must add a reference to assembly 'System.Runtime, Version=4.0.20.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'.

## steps

- Update `web.config` randomly, based on nothing more than a guess in the wind:

    <system.web>
      <compilation debug="true" targetFramework="4.7.2">
        <assemblies>
          <add assembly="netstandard, Version=2.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51"/>
          <add assembly="System.Runtime, Version=4.0.20.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"/>
        </assemblies>
      </compilation>
      <httpRuntime targetFramework="4.7.2"/>
      <httpModules/>
    </system.web>

- rebuild, etc.

## errors

no errors

# no errors

## no errors

### no errrors

#### no errors

## Facing the same issue?

Read: https://github.com/dotnet/standard/issues/481

...and good luck. :)


