# Steps taken

This follows on from the branch `net472_001_retarget`

## summary

Automatic upgrading using retargeting has failed.

Attempting to manually upgrade, as advised on https://github.com/dotnet/standard/issues/481:

- swap to using package references
- update bindings (again) in the web.config

## steps

- add `<RestoreProjectStyle>PackageReference</RestoreProjectStyle>` to project file
- patch `packages.config` using vim:

    :1,$ s/^.*package id=/<PackageReference Include=/
    :1,$ s/ targetFrame.*$/ \/>/
    :1,$ s/version/Version/

- insert references to .csproj file in an `ItemGroup`:

    <ItemGroup>
      <PackageReference Include="Antlr" Version="3.5.0.2" />
      <PackageReference Include="AutoMapper" Version="6.1.1" />
      <PackageReference Include="bootstrap" Version="3.0.0" />
      <PackageReference Include="Common.Logging" Version="3.3.0" />
      <PackageReference Include="Common.Logging.Core" Version="3.3.0" />
      <PackageReference Include="Common.Logging.Log4Net1211" Version="3.3.0" />
      <PackageReference Include="CommonServiceLocator" Version="1.3" />
      <PackageReference Include="EntityFramework" Version="6.0.0" />
      <PackageReference Include="Glimpse" Version="1.8.5" />
      <PackageReference Include="Glimpse.Ado" Version="1.7.1" />
      <PackageReference Include="Glimpse.AspNet" Version="1.9.0" />
      <PackageReference Include="Glimpse.EF6" Version="1.6.2" />
      <PackageReference Include="Glimpse.Mvc5" Version="1.5.3" />
      <PackageReference Include="HtmlRenderer.Core" Version="1.5.0.5" />
      <PackageReference Include="IdentityModel" Version="1.9.2" />
      <PackageReference Include="jQuery" Version="1.10.2" />
      <PackageReference Include="jQuery.Validation" Version="1.11.1" />
      <PackageReference Include="JSNLog" Version="2.7.7.0" />
      <PackageReference Include="JSNLog.Log4Net" Version="2.7.7" />
      <PackageReference Include="Kentor.OwinCookieSaver" Version="1.1.1" />
      <PackageReference Include="log4net" Version="2.0.8" />
      <PackageReference Include="Microsoft.AspNet.Identity.Core" Version="2.2.1" />
      <PackageReference Include="Microsoft.AspNet.Mvc" Version="5.2.3" />
      <PackageReference Include="Microsoft.AspNet.Razor" Version="3.2.3" />
      <PackageReference Include="Microsoft.AspNet.Web.Optimization" Version="1.1.3" />
      <PackageReference Include="Microsoft.AspNet.WebApi" Version="5.2.3" />
      <PackageReference Include="Microsoft.AspNet.WebApi.Client" Version="5.2.3" />
      <PackageReference Include="Microsoft.AspNet.WebApi.Core" Version="5.2.3" />
      <PackageReference Include="Microsoft.AspNet.WebApi.WebHost" Version="5.2.3" />
      <PackageReference Include="Microsoft.AspNet.WebPages" Version="3.2.3" />
      <PackageReference Include="Microsoft.AspNetCore.Antiforgery" Version="1.0.0" />
      <PackageReference Include="Microsoft.AspNetCore.Authorization" Version="1.0.0" />
      <PackageReference Include="Microsoft.AspNetCore.Cors" Version="1.0.0" />
      <PackageReference Include="Microsoft.AspNetCore.Cryptography.Internal" Version="1.0.0" />
      <PackageReference Include="Microsoft.AspNetCore.DataProtection" Version="1.0.0" />
      <PackageReference Include="Microsoft.AspNetCore.DataProtection.Abstractions" Version="1.0.0" />
      <PackageReference Include="Microsoft.AspNetCore.Diagnostics.Abstractions" Version="1.0.0" />
      <PackageReference Include="Microsoft.AspNetCore.Hosting.Abstractions" Version="1.0.0" />
      <PackageReference Include="Microsoft.AspNetCore.Hosting.Server.Abstractions" Version="1.0.0" />
      <PackageReference Include="Microsoft.AspNetCore.Html.Abstractions" Version="1.0.0" />
      <PackageReference Include="Microsoft.AspNetCore.Http" Version="1.0.0" />
      <PackageReference Include="Microsoft.AspNetCore.Http.Abstractions" Version="1.0.0" />
      <PackageReference Include="Microsoft.AspNetCore.Http.Extensions" Version="1.0.0" />
      <PackageReference Include="Microsoft.AspNetCore.Http.Features" Version="1.0.0" />
      <PackageReference Include="Microsoft.AspNetCore.JsonPatch" Version="1.0.0" />
      <PackageReference Include="Microsoft.AspNetCore.Localization" Version="1.0.0" />
      <PackageReference Include="Microsoft.AspNetCore.Mvc" Version="1.0.0" />
      <PackageReference Include="Microsoft.AspNetCore.Mvc.Abstractions" Version="1.0.0" />
      <PackageReference Include="Microsoft.AspNetCore.Mvc.ApiExplorer" Version="1.0.0" />
      <PackageReference Include="Microsoft.AspNetCore.Mvc.Core" Version="1.0.0" />
      <PackageReference Include="Microsoft.AspNetCore.Mvc.Cors" Version="1.0.0" />
      <PackageReference Include="Microsoft.AspNetCore.Mvc.DataAnnotations" Version="1.0.0" />
      <PackageReference Include="Microsoft.AspNetCore.Mvc.Formatters.Json" Version="1.0.0" />
      <PackageReference Include="Microsoft.AspNetCore.Mvc.Formatters.Xml" Version="1.0.0" />
      <PackageReference Include="Microsoft.AspNetCore.Mvc.Localization" Version="1.0.0" />
      <PackageReference Include="Microsoft.AspNetCore.Mvc.Razor" Version="1.0.0" />
      <PackageReference Include="Microsoft.AspNetCore.Mvc.Razor.Host" Version="1.0.0" />
      <PackageReference Include="Microsoft.AspNetCore.Mvc.TagHelpers" Version="1.0.0" />
      <PackageReference Include="Microsoft.AspNetCore.Mvc.ViewFeatures" Version="1.0.0" />
      <PackageReference Include="Microsoft.AspNetCore.Razor" Version="1.0.0" />
      <PackageReference Include="Microsoft.AspNetCore.Razor.Runtime" Version="1.0.0" />
      <PackageReference Include="Microsoft.AspNetCore.Routing" Version="1.0.0" />
      <PackageReference Include="Microsoft.AspNetCore.Routing.Abstractions" Version="1.0.0" />
      <PackageReference Include="Microsoft.AspNetCore.WebUtilities" Version="1.0.0" />
      <PackageReference Include="Microsoft.Bcl" Version="1.1.10" />
      <PackageReference Include="Microsoft.Bcl.Build" Version="1.0.14" />
      <PackageReference Include="Microsoft.CodeAnalysis.Analyzers" Version="1.1.0" />
      <PackageReference Include="Microsoft.CodeAnalysis.Common" Version="1.3.0" />
      <PackageReference Include="Microsoft.CodeAnalysis.CSharp" Version="1.3.0" />
      <PackageReference Include="Microsoft.CSharp" Version="4.0.1" />
      <PackageReference Include="Microsoft.DotNet.InternalAbstractions" Version="1.0.0" />
      <PackageReference Include="Microsoft.Extensions.Caching.Abstractions" Version="1.0.0" />
      <PackageReference Include="Microsoft.Extensions.Caching.Memory" Version="1.0.0" />
      <PackageReference Include="Microsoft.Extensions.Caching.SqlServer" Version="1.0.0" />
      <PackageReference Include="Microsoft.Extensions.Configuration.Abstractions" Version="1.0.0" />
      <PackageReference Include="Microsoft.Extensions.DependencyInjection" Version="1.0.0" />
      <PackageReference Include="Microsoft.Extensions.DependencyInjection.Abstractions" Version="1.0.0" />
      <PackageReference Include="Microsoft.Extensions.DependencyModel" Version="1.0.0" />
      <PackageReference Include="Microsoft.Extensions.FileProviders.Abstractions" Version="1.0.0" />
      <PackageReference Include="Microsoft.Extensions.FileProviders.Composite" Version="1.0.0" />
      <PackageReference Include="Microsoft.Extensions.FileProviders.Physical" Version="1.0.0" />
      <PackageReference Include="Microsoft.Extensions.FileSystemGlobbing" Version="1.0.0" />
      <PackageReference Include="Microsoft.Extensions.Globalization.CultureInfoCache" Version="1.0.0" />
      <PackageReference Include="Microsoft.Extensions.Localization" Version="1.0.0" />
      <PackageReference Include="Microsoft.Extensions.Localization.Abstractions" Version="1.0.0" />
      <PackageReference Include="Microsoft.Extensions.Logging.Abstractions" Version="1.0.0" />
      <PackageReference Include="Microsoft.Extensions.ObjectPool" Version="1.0.0" />
      <PackageReference Include="Microsoft.Extensions.Options" Version="1.0.0" />
      <PackageReference Include="Microsoft.Extensions.PlatformAbstractions" Version="1.0.0" />
      <PackageReference Include="Microsoft.Extensions.Primitives" Version="1.0.0" />
      <PackageReference Include="Microsoft.Extensions.WebEncoders" Version="1.0.0" />
      <PackageReference Include="Microsoft.IdentityModel.Protocol.Extensions" Version="1.0.2.206221351" />
      <PackageReference Include="Microsoft.jQuery.Unobtrusive.Ajax" Version="3.2.3" />
      <PackageReference Include="Microsoft.jQuery.Unobtrusive.Validation" Version="3.0.0" />
      <PackageReference Include="Microsoft.Net.Http" Version="2.2.29" />
      <PackageReference Include="Microsoft.Net.Http.Headers" Version="1.0.0" />
      <PackageReference Include="Microsoft.Owin" Version="3.1.0" />
      <PackageReference Include="Microsoft.Owin.Host.SystemWeb" Version="3.1.0" />
      <PackageReference Include="Microsoft.Owin.Security" Version="3.1.0" />
      <PackageReference Include="Microsoft.Owin.Security.Cookies" Version="3.1.0" />
      <PackageReference Include="Microsoft.Owin.Security.OAuth" Version="3.1.0" />
      <PackageReference Include="Microsoft.Owin.Security.OpenIdConnect" Version="3.1.0" />
      <PackageReference Include="Microsoft.Web.Infrastructure" Version="1.0.0.0" />
      <PackageReference Include="Microsoft.Web.RedisSessionStateProvider" Version="3.0.2" />
      <PackageReference Include="MicrosoftAjax" Version="4.0.20526.0" />
      <PackageReference Include="MicrosoftMvcAjax.Mvc5" Version="5.0" />
      <PackageReference Include="Modernizr" Version="2.6.2" />
      <PackageReference Include="NC-OS-SessionStateProvider" Version="4.4.0.0" />
      <PackageReference Include="Newtonsoft.Json" Version="10.0.3" />
      <PackageReference Include="Owin" Version="1.0" />
      <PackageReference Include="PerfIt" Version="0.1.5" />
      <PackageReference Include="StackExchange.Redis.StrongName" Version="1.2.6" />
      <PackageReference Include="System.AppContext" Version="4.1.0" />
      <PackageReference Include="System.Buffers" Version="4.0.0" />
      <PackageReference Include="System.Collections" Version="4.0.11" />
      <PackageReference Include="System.Collections.Concurrent" Version="4.0.12" />
      <PackageReference Include="System.Collections.Immutable" Version="1.2.0" />
      <PackageReference Include="System.ComponentModel" Version="4.0.1" />
      <PackageReference Include="System.ComponentModel.Primitives" Version="4.1.0" />
      <PackageReference Include="System.ComponentModel.TypeConverter" Version="4.1.0" />
      <PackageReference Include="System.Console" Version="4.0.0" />
      <PackageReference Include="System.Data.Common" Version="4.1.0" />
      <PackageReference Include="System.Data.SqlClient" Version="4.1.0" />
      <PackageReference Include="System.Diagnostics.Contracts" Version="4.0.1" />
      <PackageReference Include="System.Diagnostics.Debug" Version="4.0.11" />
      <PackageReference Include="System.Diagnostics.DiagnosticSource" Version="4.0.0" />
      <PackageReference Include="System.Diagnostics.FileVersionInfo" Version="4.0.0" />
      <PackageReference Include="System.Diagnostics.StackTrace" Version="4.0.1" />
      <PackageReference Include="System.Diagnostics.Tools" Version="4.0.1" />
      <PackageReference Include="System.Dynamic.Runtime" Version="4.0.11" />
      <PackageReference Include="System.Globalization" Version="4.0.11" />
      <PackageReference Include="System.IdentityModel.Tokens.Jwt" Version="4.0.2.206221351" />
      <PackageReference Include="System.IdentityModel.Tokens.ValidatingIssuerNameRegistry" Version="4.5.1" />
      <PackageReference Include="System.IO" Version="4.1.0" />
      <PackageReference Include="System.IO.FileSystem" Version="4.0.1" />
      <PackageReference Include="System.IO.FileSystem.Primitives" Version="4.0.1" />
      <PackageReference Include="System.Linq" Version="4.1.0" />
      <PackageReference Include="System.Linq.Expressions" Version="4.1.0" />
      <PackageReference Include="System.Linq.Queryable" Version="4.0.0" />
      <PackageReference Include="System.Net.Http" Version="4.3.2" />
      <PackageReference Include="System.Reflection" Version="4.1.0" />
      <PackageReference Include="System.Reflection.Extensions" Version="4.0.1" />
      <PackageReference Include="System.Reflection.Metadata" Version="1.3.0" />
      <PackageReference Include="System.Reflection.Primitives" Version="4.0.1" />
      <PackageReference Include="System.Resources.ResourceManager" Version="4.0.1" />
      <PackageReference Include="System.Runtime" Version="4.1.0" />
      <PackageReference Include="System.Runtime.Extensions" Version="4.1.0" />
      <PackageReference Include="System.Runtime.Handles" Version="4.0.1" />
      <PackageReference Include="System.Runtime.InteropServices" Version="4.1.0" />
      <PackageReference Include="System.Runtime.Numerics" Version="4.0.1" />
      <PackageReference Include="System.Runtime.Serialization.Primitives" Version="4.1.1" />
      <PackageReference Include="System.Security.Cryptography.Algorithms" Version="4.3.0" />
      <PackageReference Include="System.Security.Cryptography.Encoding" Version="4.3.0" />
      <PackageReference Include="System.Security.Cryptography.Primitives" Version="4.3.0" />
      <PackageReference Include="System.Security.Cryptography.X509Certificates" Version="4.3.0" />
      <PackageReference Include="System.Text.Encoding" Version="4.0.11" />
      <PackageReference Include="System.Text.Encoding.CodePages" Version="4.0.1" />
      <PackageReference Include="System.Text.Encoding.Extensions" Version="4.0.11" />
      <PackageReference Include="System.Text.Encodings.Web" Version="4.0.0" />
      <PackageReference Include="System.Threading" Version="4.0.11" />
      <PackageReference Include="System.Threading.Tasks" Version="4.0.11" />
      <PackageReference Include="System.Threading.Tasks.Parallel" Version="4.0.1" />
      <PackageReference Include="System.Threading.Thread" Version="4.0.0" />
      <PackageReference Include="System.Xml.ReaderWriter" Version="4.0.11" />
      <PackageReference Include="System.Xml.XDocument" Version="4.0.11" />
      <PackageReference Include="System.Xml.XmlDocument" Version="4.0.1" />
      <PackageReference Include="System.Xml.XPath" Version="4.0.1" />
      <PackageReference Include="System.Xml.XPath.XDocument" Version="4.0.1" />
      <PackageReference Include="Thinktecture.IdentityModel" Version="3.6.1" />
      <PackageReference Include="Thinktecture.IdentityModel.Client" Version="4.0.1" />
      <PackageReference Include="Unity" Version="4.0.1" />
      <PackageReference Include="Unity.AspNet.WebApi" Version="4.0.1" />
      <PackageReference Include="Unity.Mvc" Version="4.0.1" />
      <PackageReference Include="Unity.WebAPI" Version="5.2.3" />
      <PackageReference Include="WebActivatorEx" Version="2.0.5" />
      <PackageReference Include="WebConfigTransformRunner" Version="1.0.0.1" />
      <PackageReference Include="WebGrease" Version="1.6.0" />
    </ItemGroup>

- Remove all `Reference` elements in the .csproj, like:

    <Reference Include="Antlr3.Runtime, Version=3.5.0.2, Culture=neutral, PublicKeyToken=eb42632606e9261f, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\packages\Antlr.3.5.0.2\lib\Antlr3.Runtime.dll</HintPath>
    </Reference>

- delete `packages.config`
- delete reference to `packages.config` from .csproj:


    @@ -120,529 +300,9 @@
         <Content Include="Content\bootstrap.css.map" />
         <Content Include="Content\bootstrap-theme.min.css.map" />
         <Content Include="Content\bootstrap-theme.css.map" />
         <None Include="packages.config" />

- delete packages, bin, obj
- close visual studio, restart visual studio, reload solution^
- rebuild solution

^ Note: VS totally confused and broken by these .csproj file changes. Had to restart VS.

## errors

    Severity	Code	Description	Project	File	Line	Suppression State
    Error		This project references NuGet package(s) that are missing on this computer. Enable NuGet Package Restore to download them.  For more information, see http://go.microsoft.com/fwlink/?LinkID=317567.	DemoApp	C:\projects\3rdparty\migrateProject\DemoApp\DemoApp\DemoApp.csproj	323	

    Severity	Code	Description	Project	File	Line	Suppression State
    Error		Some NuGet packages were installed using a target framework different from the current target framework and may need to be reinstalled. Visit http://docs.nuget.org/docs/workflows/reinstalling-packages for more information.  Packages affected: Microsoft.Web.RedisSessionStateProvider, System.AppContext, System.ComponentModel.TypeConverter, System.IO, System.Linq, System.Linq.Expressions, System.Reflection, System.Runtime, System.Runtime.Extensions, System.Runtime.InteropServices, System.Security.Cryptography.Algorithms, System.Security.Cryptography.X509Certificates	Solution 'DemoApp' ‎(1 project)		0	

## steps

note: VS is unable to do anything meaningful at this point. Forced to use command line.

- powershell > `nuget restore` from solution folder:

    $ nuget restore
    MSBuild auto-detection: using msbuild version '15.8.168.64424' from 'C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\MSBuild\15.0\bin'.
    WARNING: NU1605: Detected package downgrade: System.IO from 4.3.0 to 4.1.0. Reference the package directly from the project to select a different version.
     DemoApp -> System.Security.Cryptography.Algorithms 4.3.0 -> System.IO (>= 4.3.0)
     DemoApp -> System.IO (>= 4.1.0)
    WARNING: NU1605: Detected package downgrade: System.Runtime from 4.3.0 to 4.1.0. Reference the package directly from the project to select a different version.
     DemoApp -> System.Security.Cryptography.Algorithms 4.3.0 -> System.Runtime (>= 4.3.0)
     DemoApp -> System.Runtime (>= 4.1.0)
    Committing restore...
    Assets file has not changed. Skipping assets file writing. Path: C:\projects\3rdparty\migrateProject\DemoApp\DemoApp\obj\project.assets.json
    Restore completed in 174.09 ms for C:\projects\3rdparty\migrateProject\DemoApp\DemoApp\DemoApp.csproj.

    NuGet Config files used:
        C:\Users\Douglas.Linder\AppData\Roaming\NuGet\NuGet.Config
        C:\Program Files (x86)\NuGet\Config\Microsoft.VisualStudio.Offline.config

    Feeds used:
        C:\Program Files (x86)\Microsoft SDKs\NuGetPackages\
        https://api.nuget.org/v3/index.json

- reopen in VS
- delete bin, obj folders
- rebuild

## errors

    Severity	Code	Description	Project	File	Line	Suppression State
    Error		This project references NuGet package(s) that are missing on this computer. Enable NuGet Package Restore to download them.  For more information, see http://go.microsoft.com/fwlink/?LinkID=317567.	DemoApp	C:\projects\3rdparty\migrateProject\DemoApp\DemoApp\DemoApp.csproj	324	

## steps

- :( :( :(
- remove these lines from the .csproj file:

    <Target Name="EnsureBclBuildImported" BeforeTargets="BeforeBuild" Condition="'$(BclBuildImported)' == ''">
      <Error Condition="!Exists('..\packages\Microsoft.Bcl.Build.1.0.14\tools\Microsoft.Bcl.Build.targets')" Text="This project references NuGet package(s) that are missing on this computer. Enable NuGet Package Restore to download them.  For more information, see http://go.microsoft.com/fwlink/?LinkID=317567." HelpKeyword="BCLBUILD2001" />
      <Error Condition="Exists('..\packages\Microsoft.Bcl.Build.1.0.14\tools\Microsoft.Bcl.Build.targets')" Text="The build restored NuGet packages. Build the project again to include these packages in the build. For more information, see http://go.microsoft.com/fwlink/?LinkID=317568." HelpKeyword="BCLBUILD2002" />
    </Target>

- reopen in VS
- delete bin, obj folders
- rebuild
- no build errors

## errors

runtime error:

    Server Error in '/' Application.
    Compilation Error
    Description: An error occurred during the compilation of a resource required to service this request. Please review the following specific error details and modify your source code appropriately.

    Compiler Error Message: CS0012: The type 'System.Object' is defined in an assembly that is not referenced. You must add a reference to assembly 'System.Runtime, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'.

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
