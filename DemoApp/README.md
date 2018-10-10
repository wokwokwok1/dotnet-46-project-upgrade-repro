# Steps taken

This follows on from the branch `net472_002_migratePackages`

## summary

Automatic upgrading using retargeting has failed.

Manually migrating to use package references has failed.

Application compiles without error, but at runtime we see:

    Compiler Error Message: CS0012: The type 'System.Object' is defined in an assembly that is not referenced. You must add a reference to assembly 'System.Runtime, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'.

## steps

- remove all assembly bindings from web.config
- delete bin, obj folders
- rebuild

## errors 

Suggested assembly bindings from vs tooling:

    Severity	Code	Description	Project	File	Line	Suppression State
    Warning		Found conflicts between different versions of the same dependent assembly. In Visual Studio, double-click this warning (or select it and press Enter) to fix the conflicts; otherwise, add the following binding redirects to the "runtime" node in the application configuration file: <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1"><dependentAssembly><assemblyIdentity name="Antlr3.Runtime" culture="neutral" publicKeyToken="eb42632606e9261f" /><bindingRedirect oldVersion="0.0.0.0-3.5.0.2" newVersion="3.5.0.2" /></dependentAssembly></assemblyBinding><assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1"><dependentAssembly><assemblyIdentity name="Common.Logging" culture="neutral" publicKeyToken="af08829b84f0328e" /><bindingRedirect oldVersion="0.0.0.0-3.3.0.0" newVersion="3.3.0.0" /></dependentAssembly></assemblyBinding><assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1"><dependentAssembly><assemblyIdentity name="log4net" culture="neutral" publicKeyToken="669e0ddf0bb1aa2a" /><bindingRedirect oldVersion="0.0.0.0-2.0.8.0" newVersion="2.0.8.0" /></dependentAssembly></assemblyBinding><assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1"><dependentAssembly><assemblyIdentity name="System.Web.Mvc" culture="neutral" publicKeyToken="31bf3856ad364e35" /><bindingRedirect oldVersion="0.0.0.0-5.2.3.0" newVersion="5.2.3.0" /></dependentAssembly></assemblyBinding><assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1"><dependentAssembly><assemblyIdentity name="System.Net.Http.Formatting" culture="neutral" publicKeyToken="31bf3856ad364e35" /><bindingRedirect oldVersion="0.0.0.0-5.2.3.0" newVersion="5.2.3.0" /></dependentAssembly></assemblyBinding><assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1"><dependentAssembly><assemblyIdentity name="System.Web.Http" culture="neutral" publicKeyToken="31bf3856ad364e35" /><bindingRedirect oldVersion="0.0.0.0-5.2.3.0" newVersion="5.2.3.0" /></dependentAssembly></assemblyBinding><assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1"><dependentAssembly><assemblyIdentity name="Microsoft.IdentityModel.Protocol.Extensions" culture="neutral" publicKeyToken="31bf3856ad364e35" /><bindingRedirect oldVersion="0.0.0.0-1.0.2.33" newVersion="1.0.2.33" /></dependentAssembly></assemblyBinding><assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1"><dependentAssembly><assemblyIdentity name="Microsoft.Owin" culture="neutral" publicKeyToken="31bf3856ad364e35" /><bindingRedirect oldVersion="0.0.0.0-3.1.0.0" newVersion="3.1.0.0" /></dependentAssembly></assemblyBinding><assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1"><dependentAssembly><assemblyIdentity name="Newtonsoft.Json" culture="neutral" publicKeyToken="30ad4fe6b2a6aeed" /><bindingRedirect oldVersion="0.0.0.0-10.0.0.0" newVersion="10.0.0.0" /></dependentAssembly></assemblyBinding><assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1"><dependentAssembly><assemblyIdentity name="System.Collections.Immutable" culture="neutral" publicKeyToken="b03f5f7f11d50a3a" /><bindingRedirect oldVersion="0.0.0.0-1.2.0.0" newVersion="1.2.0.0" /></dependentAssembly></assemblyBinding><assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1"><dependentAssembly><assemblyIdentity name="System.Data.SqlClient" culture="neutral" publicKeyToken="b03f5f7f11d50a3a" /><bindingRedirect oldVersion="0.0.0.0-4.1.0.0" newVersion="4.1.0.0" /></dependentAssembly></assemblyBinding><assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1"><dependentAssembly><assemblyIdentity name="System.IdentityModel.Tokens.Jwt" culture="neutral" publicKeyToken="31bf3856ad364e35" /><bindingRedirect oldVersion="0.0.0.0-4.0.20622.1351" newVersion="4.0.20622.1351" /></dependentAssembly></assemblyBinding><assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1"><dependentAssembly><assemblyIdentity name="System.Reflection.Metadata" culture="neutral" publicKeyToken="b03f5f7f11d50a3a" /><bindingRedirect oldVersion="0.0.0.0-1.3.0.0" newVersion="1.3.0.0" /></dependentAssembly></assemblyBinding><assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1"><dependentAssembly><assemblyIdentity name="WebGrease" culture="neutral" publicKeyToken="31bf3856ad364e35" /><bindingRedirect oldVersion="0.0.0.0-1.6.5135.21930" newVersion="1.6.5135.21930" /></dependentAssembly></assemblyBinding>	DemoApp			

## steps

- double click warning
- automatically update `web.config`
- `web.config` now contains:

    <?xml version="1.0"?>
    <!--
      For more information on how to configure your ASP.NET application, please visit
      https://go.microsoft.com/fwlink/?LinkId=301880
      -->
    <configuration>
      <configSections>
        <!-- For more information on Entity Framework configuration, visit http://go.microsoft.com/fwlink/?LinkID=237468 -->
        <section name="entityFramework" type="System.Data.Entity.Internal.ConfigFile.EntityFrameworkSection, EntityFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" requirePermission="false"/>
        <!-- For more information on Entity Framework configuration, visit http://go.microsoft.com/fwlink/?LinkID=237468 -->
      </configSections>
      <appSettings>
        <add key="webpages:Version" value="3.0.0.0"/>
        <add key="webpages:Enabled" value="false"/>
        <add key="ClientValidationEnabled" value="true"/>
        <add key="UnobtrusiveJavaScriptEnabled" value="true"/>
      </appSettings>
      <!--
        For a description of web.config changes see http://go.microsoft.com/fwlink/?LinkId=235367.

        The following attributes can be set on the <httpRuntime> tag.
          <system.Web>
            <httpRuntime targetFramework="4.7.2" />
          </system.Web>
      -->
      <system.web>
        <compilation debug="true" targetFramework="4.7.2"/>
        <httpRuntime targetFramework="4.6"/>
        <httpModules/>
      </system.web>
      <runtime>
        <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
          <dependentAssembly>
            <assemblyIdentity name="WebGrease" publicKeyToken="31BF3856AD364E35" culture="neutral"/>
            <bindingRedirect oldVersion="0.0.0.0-1.6.5135.21930" newVersion="1.6.5135.21930"/>
          </dependentAssembly>
          <dependentAssembly>
            <assemblyIdentity name="System.Reflection.Metadata" publicKeyToken="B03F5F7F11D50A3A" culture="neutral"/>
            <bindingRedirect oldVersion="0.0.0.0-1.3.0.0" newVersion="1.3.0.0"/>
          </dependentAssembly>
          <dependentAssembly>
            <assemblyIdentity name="System.IdentityModel.Tokens.Jwt" publicKeyToken="31BF3856AD364E35" culture="neutral"/>
            <bindingRedirect oldVersion="0.0.0.0-4.0.20622.1351" newVersion="4.0.20622.1351"/>
          </dependentAssembly>
          <dependentAssembly>
            <assemblyIdentity name="System.Data.SqlClient" publicKeyToken="B03F5F7F11D50A3A" culture="neutral"/>
            <bindingRedirect oldVersion="0.0.0.0-4.1.0.0" newVersion="4.1.0.0"/>
          </dependentAssembly>
          <dependentAssembly>
            <assemblyIdentity name="System.Collections.Immutable" publicKeyToken="B03F5F7F11D50A3A" culture="neutral"/>
            <bindingRedirect oldVersion="0.0.0.0-1.2.0.0" newVersion="1.2.0.0"/>
          </dependentAssembly>
          <dependentAssembly>
            <assemblyIdentity name="Newtonsoft.Json" publicKeyToken="30AD4FE6B2A6AEED" culture="neutral"/>
            <bindingRedirect oldVersion="0.0.0.0-10.0.0.0" newVersion="10.0.0.0"/>
          </dependentAssembly>
          <dependentAssembly>
            <assemblyIdentity name="Microsoft.Owin" publicKeyToken="31BF3856AD364E35" culture="neutral"/>
            <bindingRedirect oldVersion="0.0.0.0-3.1.0.0" newVersion="3.1.0.0"/>
          </dependentAssembly>
          <dependentAssembly>
            <assemblyIdentity name="Microsoft.IdentityModel.Protocol.Extensions" publicKeyToken="31BF3856AD364E35" culture="neutral"/>
            <bindingRedirect oldVersion="0.0.0.0-1.0.2.33" newVersion="1.0.2.33"/>
          </dependentAssembly>
          <dependentAssembly>
            <assemblyIdentity name="System.Web.Http" publicKeyToken="31BF3856AD364E35" culture="neutral"/>
            <bindingRedirect oldVersion="0.0.0.0-5.2.3.0" newVersion="5.2.3.0"/>
          </dependentAssembly>
          <dependentAssembly>
            <assemblyIdentity name="System.Net.Http.Formatting" publicKeyToken="31BF3856AD364E35" culture="neutral"/>
            <bindingRedirect oldVersion="0.0.0.0-5.2.3.0" newVersion="5.2.3.0"/>
          </dependentAssembly>
          <dependentAssembly>
            <assemblyIdentity name="System.Web.Mvc" publicKeyToken="31BF3856AD364E35" culture="neutral"/>
            <bindingRedirect oldVersion="0.0.0.0-5.2.3.0" newVersion="5.2.3.0"/>
          </dependentAssembly>
          <dependentAssembly>
            <assemblyIdentity name="log4net" publicKeyToken="669E0DDF0BB1AA2A" culture="neutral"/>
            <bindingRedirect oldVersion="0.0.0.0-2.0.8.0" newVersion="2.0.8.0"/>
          </dependentAssembly>
          <dependentAssembly>
            <assemblyIdentity name="Common.Logging" publicKeyToken="AF08829B84F0328E" culture="neutral"/>
            <bindingRedirect oldVersion="0.0.0.0-3.3.0.0" newVersion="3.3.0.0"/>
          </dependentAssembly>
          <dependentAssembly>
            <assemblyIdentity name="Antlr3.Runtime" publicKeyToken="EB42632606E9261F" culture="neutral"/>
            <bindingRedirect oldVersion="0.0.0.0-3.5.0.2" newVersion="3.5.0.2"/>
          </dependentAssembly>
        </assemblyBinding>
      </runtime>
      <system.webServer>
        <modules/>
        <validation validateIntegratedModeConfiguration="false"/>
      </system.webServer>
      <entityFramework>
        <defaultConnectionFactory type="System.Data.Entity.Infrastructure.LocalDbConnectionFactory, EntityFramework">
          <parameters>
            <parameter value="mssqllocaldb"/>
          </parameters>
        </defaultConnectionFactory>
        <providers>
          <provider invariantName="System.Data.SqlClient" type="System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer"/>
        </providers>
      </entityFramework>
    </configuration>

- delete bin, obj folders
- rebuild
- no errors
- run using IIS Express
- run using IIS

## errors

    Server Error in '/' Application.
    Compilation Error
    Description: An error occurred during the compilation of a resource required to service this request. Please review the following specific error details and modify your source code appropriately.

    Compiler Error Message: CS0012: The type 'System.Object' is defined in an assembly that is not referenced. You must add a reference to assembly 'System.Runtime, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'.

## steps

- `grep "System.Web.Http" * -R`
- remove `System.Web.Http` from `.nuget/packages.config`^
- remove all bindings from web.config
- delete bin, obj folders
- rebuild
- accept suggested bindings
- `web.config` still contains:

    <dependentAssembly>
      <assemblyIdentity name="System.Web.Http" publicKeyToken="31BF3856AD364E35" culture="neutral"/>
      <bindingRedirect oldVersion="0.0.0.0-5.2.3.0" newVersion="5.2.3.0"/>
    </dependentAssembly>

- no errors

^ I have no idea what this file is or why it exists, there's no-one who recalls adding it, but its definitely not a default file.

## errors

Same runtime error

## steps

- attempt to install `Microsoft.CodeDom.Providers.DotNetCompilerPlatform` as recommended by https://stackoverflow.com/questions/42707874/nuget-package-for-tuples-in-c7-causes-an-error-in-my-views

## errors

Same runtime error

## steps

- revert changes
- open package manager console
- remove all bindings from web.config^
- delete bin, obj folders
- `Update-Package -reinstall`

    PM> Update-Package -reinstall
    Restoring packages for C:\projects\3rdparty\migrateProject\DemoApp\DemoApp\DemoApp.csproj...
    NU1605: Detected package downgrade: System.IO from 4.3.0 to 4.1.0. Reference the package directly from the project to select a different version. 
     DemoApp -> System.Security.Cryptography.Algorithms 4.3.0 -> System.IO (>= 4.3.0) 
     DemoApp -> System.IO (>= 4.1.0)
    NU1605: Detected package downgrade: System.Runtime from 4.3.0 to 4.1.0. Reference the package directly from the project to select a different version. 
     DemoApp -> System.Security.Cryptography.Algorithms 4.3.0 -> System.Runtime (>= 4.3.0) 
     DemoApp -> System.Runtime (>= 4.1.0)
    Restoring packages for C:\projects\3rdparty\migrateProject\DemoApp\DemoApp\DemoApp.csproj...
      GET https://api.nuget.org/v3-flatcontainer/htmlrenderer.core/index.json
      OK https://api.nuget.org/v3-flatcontainer/htmlrenderer.core/index.json 1371ms
      GET https://api.nuget.org/v3-flatcontainer/htmlrenderer.core/1.5.0.6/htmlrenderer.core.1.5.0.6.nupkg
      OK https://api.nuget.org/v3-flatcontainer/htmlrenderer.core/1.5.0.6/htmlrenderer.core.1.5.0.6.nupkg 949ms
    Installing HtmlRenderer.Core 1.5.0.6.
    NU1605: Detected package downgrade: System.IO from 4.3.0 to 4.1.0. Reference the package directly from the project to select a different version. 
     DemoApp -> System.Security.Cryptography.Algorithms 4.3.0 -> System.IO (>= 4.3.0) 
     DemoApp -> System.IO (>= 4.1.0)
    NU1605: Detected package downgrade: System.Runtime from 4.3.0 to 4.1.0. Reference the package directly from the project to select a different version. 
     DemoApp -> System.Security.Cryptography.Algorithms 4.3.0 -> System.Runtime (>= 4.3.0) 
     DemoApp -> System.Runtime (>= 4.1.0)
    Committing restore...
    Generating MSBuild file C:\projects\3rdparty\migrateProject\DemoApp\DemoApp\obj\DemoApp.csproj.nuget.g.props.
    Generating MSBuild file C:\projects\3rdparty\migrateProject\DemoApp\DemoApp\obj\DemoApp.csproj.nuget.g.targets.
    Writing lock file to disk. Path: C:\projects\3rdparty\migrateProject\DemoApp\DemoApp\obj\project.assets.json
    Restore completed in 4.03 sec for C:\projects\3rdparty\migrateProject\DemoApp\DemoApp\DemoApp.csproj.
    Successfully uninstalled 'HtmlRenderer.Core 1.5.0.5' from DemoApp
    Successfully installed 'HtmlRenderer.Core 1.5.0.6' to DemoApp
    Executing nuget actions took 341.32 ms
    Time Elapsed: 00:04:29.9639823

- rebuild
- accept suggested bindings
- delete bin, obj folders
- rebuild

    NU1605: Detected package downgrade: System.IO from 4.3.0 to 4.1.0. Reference the package directly from the project to select a different version. 
     DemoApp -> System.Security.Cryptography.Algorithms 4.3.0 -> System.IO (>= 4.3.0) 
     DemoApp -> System.IO (>= 4.1.0)
    NU1605: Detected package downgrade: System.Runtime from 4.3.0 to 4.1.0. Reference the package directly from the project to select a different version. 
     DemoApp -> System.Security.Cryptography.Algorithms 4.3.0 -> System.Runtime (>= 4.3.0) 
     DemoApp -> System.Runtime (>= 4.1.0)
    1>------ Build started: Project: DemoApp, Configuration: Debug Any CPU ------
    1>  DemoApp -> C:\projects\3rdparty\migrateProject\DemoApp\DemoApp\bin\DemoApp.dll
    ========== Build: 1 succeeded, 0 failed, 0 up-to-date, 0 skipped ==========

^ Strangely, doing this out of order (update before removing bindings) resulted in a *different set of packages* being installed. Note to self: always remove bindings before any operation.

## errors

Same runtime error

## steps

- manually add binding for system.runtime^

    <dependentAssembly>
      <assemblyIdentity name="System.Runtime" publicKeyToken="b03f5f7f11d50a3a" culture="neutral"/>
      <bindingRedirect oldVersion="0.0.0.0-4.3.0.0" newVersion="4.1.0.0"/>
    </dependentAssembly>

- rebuild, VS warns of incompatible version
- accept suggested web.config changes
- vs now geneates *this* magical binding string^^

    <dependentAssembly>
      <assemblyIdentity name="System.Runtime" publicKeyToken="B03F5F7F11D50A3A" culture="neutral"/>
      <bindingRedirect oldVersion="0.0.0.0-4.1.2.0" newVersion="4.1.2.0"/>
    </dependentAssembly>

^ No particular reason, I'm just randomly trying crap off stack overflow at this point.

^^ ?? I retried this several times, but unless I manually put a binding in there first, it won't auto-generate this. What the fuck.

## errors

    Server Error in '/' Application.
    Could not load file or assembly 'System.Runtime, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' or one of its dependencies. The system cannot find the file specified.
    Description: An unhandled exception occurred during the execution of the current web request. Please review the stack trace for more information about the error and where it originated in the code.

    Exception Details: System.IO.FileNotFoundException: Could not load file or assembly 'System.Runtime, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' or one of its dependencies. The system cannot find the file specified.

    Source Error:

    An unhandled exception was generated during the execution of the current web request. Information regarding the origin and location of the exception can be identified using the exception stack trace below.

    Assembly Load Trace: The following information can be helpful to determine why the assembly 'System.Runtime, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' could not be loaded.


    === Pre-bind state information ===
    LOG: DisplayName = System.Runtime, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
     (Fully-specified)
    LOG: Appbase = file:///C:/projects/3rdparty/migrateProject/DemoApp/DemoApp/
    LOG: Initial PrivatePath = C:\projects\3rdparty\migrateProject\DemoApp\DemoApp\bin
    Calling assembly : Microsoft.Extensions.FileProviders.Abstractions, Version=1.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60.
    ===
    LOG: This bind starts in default load context.
    LOG: Using application configuration file: C:\projects\3rdparty\migrateProject\DemoApp\DemoApp\web.config
    LOG: Using host configuration file: C:\Users\Douglas.Linder\Documents\IISExpress\config\aspnet.config
    LOG: Using machine configuration file from C:\Windows\Microsoft.NET\Framework\v4.0.30319\config\machine.config.
    LOG: Redirect found in application configuration file: 4.0.0.0 redirected to 4.1.2.0.
    LOG: Post-policy reference: System.Runtime, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
    LOG: The same bind was seen before, and was failed with hr = 0x80070002.


    Stack Trace:


    [FileNotFoundException: Could not load file or assembly 'System.Runtime, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' or one of its dependencies. The system cannot find the file specified.]

    [FileNotFoundException: Could not load file or assembly 'System.Runtime, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' or one of its dependencies. The system cannot find the file specified.]
       System.ModuleHandle.ResolveType(RuntimeModule module, Int32 typeToken, IntPtr* typeInstArgs, Int32 typeInstCount, IntPtr* methodInstArgs, Int32 methodInstCount, ObjectHandleOnStack type) +0
       System.ModuleHandle.ResolveTypeHandleInternal(RuntimeModule module, Int32 typeToken, RuntimeTypeHandle[] typeInstantiationContext, RuntimeTypeHandle[] methodInstantiationContext) +145
       System.Reflection.RuntimeModule.ResolveType(Int32 metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments) +130
       System.Reflection.CustomAttribute.FilterCustomAttributeRecord(CustomAttributeRecord caRecord, MetadataImport scope, Assembly& lastAptcaOkAssembly, RuntimeModule decoratedModule, MetadataToken decoratedToken, RuntimeType attributeFilterType, Boolean mustBeInheritable, Object[] attributes, IList derivedAttributes, RuntimeType& attributeType, IRuntimeMethodInfo& ctor, Boolean& ctorHasParameters, Boolean& isVarArg) +91
       System.Reflection.CustomAttribute.GetCustomAttributes(RuntimeModule decoratedModule, Int32 decoratedMetadataToken, Int32 pcaCount, RuntimeType attributeFilterType, Boolean mustBeInheritable, IList derivedAttributes, Boolean isDecoratedTargetSecurityTransparent) +418
       System.Reflection.CustomAttribute.GetCustomAttributes(RuntimeAssembly assembly, RuntimeType caType) +103
       System.Reflection.RuntimeAssembly.GetCustomAttributes(Boolean inherit) +37
       Owin.Loader.DefaultLoader.SearchForStartupAttribute(String friendlyName, IList`1 errors, Boolean& conflict) +106
       Owin.Loader.DefaultLoader.GetDefaultConfiguration(String friendlyName, IList`1 errors) +46
       Owin.Loader.DefaultLoader.LoadImplementation(String startupName, IList`1 errorDetails) +76
       Owin.Loader.DefaultLoader.Load(String startupName, IList`1 errorDetails) +21
       Microsoft.Owin.Host.SystemWeb.OwinBuilder.GetAppStartup() +115
       Microsoft.Owin.Host.SystemWeb.OwinHttpModule.InitializeBlueprint() +28
       System.Threading.LazyInitializer.EnsureInitializedCore(T& target, Boolean& initialized, Object& syncLock, Func`1 valueFactory) +115
       Microsoft.Owin.Host.SystemWeb.OwinHttpModule.Init(HttpApplication context) +106
       System.Web.HttpApplication.RegisterEventSubscriptionsWithIIS(IntPtr appContext, HttpContext context, MethodInfo[] handlers) +523
       System.Web.HttpApplication.InitSpecial(HttpApplicationState state, MethodInfo[] handlers, IntPtr appContext, HttpContext context) +176
       System.Web.HttpApplicationFactory.GetSpecialApplicationInstance(IntPtr appContext, HttpContext context) +220
       System.Web.Hosting.PipelineRuntime.InitializeApplication(IntPtr appContext) +303

    [HttpException (0x80004005): Could not load file or assembly 'System.Runtime, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' or one of its dependencies. The system cannot find the file specified.]
       System.Web.HttpRuntime.FirstRequestInit(HttpContext context) +658
       System.Web.HttpRuntime.EnsureFirstRequestInit(HttpContext context) +89
       System.Web.HttpRuntime.ProcessRequestNotificationPrivate(IIS7WorkerRequest wr, HttpContext context) +188


    Version Information: Microsoft .NET Framework Version:4.0.30319; ASP.NET Version:4.7.3160.0 
        System.IO.FileNotFoundException: Could not load file or assembly 'System.Runtime, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' or one of its dependencies. The system cannot find the file specified.

## steps

- Add `<PackageReference Include="System.Runtime" Version="4.1.0" />
- rebuild, etc.
- nuget console, upgrade version of `System.Runtime`:

    Restoring packages for C:\projects\3rdparty\migrateProject\DemoApp\DemoApp\DemoApp.csproj...
      GET https://api.nuget.org/v3-flatcontainer/system.runtime/index.json
      OK https://api.nuget.org/v3-flatcontainer/system.runtime/index.json 257ms
      GET https://api.nuget.org/v3-flatcontainer/system.runtime/4.3.0/system.runtime.4.3.0.nupkg
      OK https://api.nuget.org/v3-flatcontainer/system.runtime/4.3.0/system.runtime.4.3.0.nupkg 54ms
    Installing System.Runtime 4.3.0.
    NU1605: Detected package downgrade: System.IO from 4.3.0 to 4.1.0. Reference the package directly from the project to select a different version. 
     DemoApp -> System.Security.Cryptography.Algorithms 4.3.0 -> System.IO (>= 4.3.0) 
     DemoApp -> System.IO (>= 4.1.0)
    Committing restore...
    Writing lock file to disk. Path: C:\projects\3rdparty\migrateProject\DemoApp\DemoApp\obj\project.assets.json
    Restore completed in 5.1 sec for C:\projects\3rdparty\migrateProject\DemoApp\DemoApp\DemoApp.csproj.
    Successfully uninstalled 'System.Runtime 4.1.0' from DemoApp
    Successfully installed 'System.Runtime 4.3.0' to DemoApp
    Executing nuget actions took 2.68 sec
    Time Elapsed: 00:00:08.9315532
    ========== Finished ==========

## errors

    Could not load file or assembly 'System.Runtime, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' or one of its dependencies. The system cannot find the file specified.
    Description: An unhandled exception occurred during the execution of the current web request. Please review the stack trace for more information about the error and where it originated in the code. 

    Exception Details: System.IO.FileNotFoundException: Could not load file or assembly 'System.Runtime, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' or one of its dependencies. The system cannot find the file specified.

    Source Error: 

    An unhandled exception was generated during the execution of the current web request. Information regarding the origin and location of the exception can be identified using the exception stack trace below.

    Assembly Load Trace: The following information can be helpful to determine why the assembly 'System.Runtime, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' could not be loaded.


    WRN: Assembly binding logging is turned OFF.
    To enable assembly bind failure logging, set the registry value [HKLM\Software\Microsoft\Fusion!EnableLog] (DWORD) to 1.
    Note: There is some performance penalty associated with assembly bind failure logging.
    To turn this feature off, remove the registry value [HKLM\Software\Microsoft\Fusion!EnableLog].

    Stack Trace: 


    [FileNotFoundException: Could not load file or assembly 'System.Runtime, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' or one of its dependencies. The system cannot find the file specified.]

    [FileNotFoundException: Could not load file or assembly 'System.Runtime, Version=4.3.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' or one of its dependencies. The system cannot find the file specified.]
       System.ModuleHandle.ResolveType(RuntimeModule module, Int32 typeToken, IntPtr* typeInstArgs, Int32 typeInstCount, IntPtr* methodInstArgs, Int32 methodInstCount, ObjectHandleOnStack type) +0
       System.ModuleHandle.ResolveTypeHandleInternal(RuntimeModule module, Int32 typeToken, RuntimeTypeHandle[] typeInstantiationContext, RuntimeTypeHandle[] methodInstantiationContext) +191
       System.Reflection.RuntimeModule.ResolveType(Int32 metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments) +161

## steps

- upgrade `System.IO` to 4.3.0^
- rebuild etc.

^ More random suggestions from stack overflow

## error

On compile:

    Severity	Code	Description	Project	File	Line	Suppression State
    Warning		Found conflicts between different versions of "System.Runtime" that could not be resolved.  These reference conflicts are listed in the build log when log verbosity is set to detailed.	DemoApp			

## steps

- remove `System.Runtime` dependency
- untick 'Auto-generate binding redirects'
- .csproj diff:

    diff --git a/DemoApp/DemoApp/DemoApp.csproj b/DemoApp/DemoApp/DemoApp.csproj
    index 41b11b7..f0d3245 100644
    --- a/DemoApp/DemoApp/DemoApp.csproj
    +++ b/DemoApp/DemoApp/DemoApp.csproj
    @@ -67,7 +67,7 @@
         <PackageReference Include="Glimpse.AspNet" Version="1.9.0" />
         <PackageReference Include="Glimpse.EF6" Version="1.6.2" />
         <PackageReference Include="Glimpse.Mvc5" Version="1.5.3" />
    -    <PackageReference Include="HtmlRenderer.Core" Version="1.5.0.5" />
    +    <PackageReference Include="HtmlRenderer.Core" Version="1.5.0.6" />^M
         <PackageReference Include="IdentityModel" Version="1.9.2" />
         <PackageReference Include="jQuery" Version="1.10.2" />
         <PackageReference Include="jQuery.Validation" Version="1.11.1" />
    @@ -187,7 +187,7 @@
         <PackageReference Include="System.Globalization" Version="4.0.11" />
         <PackageReference Include="System.IdentityModel.Tokens.Jwt" Version="4.0.2.206221351" />
         <PackageReference Include="System.IdentityModel.Tokens.ValidatingIssuerNameRegistry" Version="4.5.1" />
    -    <PackageReference Include="System.IO" Version="4.1.0" />
    +    <PackageReference Include="System.IO" Version="4.3.0" />^M
         <PackageReference Include="System.IO.FileSystem" Version="4.0.1" />
         <PackageReference Include="System.IO.FileSystem.Primitives" Version="4.0.1" />
         <PackageReference Include="System.Linq" Version="4.1.0" />
    @@ -199,7 +199,6 @@
         <PackageReference Include="System.Reflection.Metadata" Version="1.3.0" />
         <PackageReference Include="System.Reflection.Primitives" Version="4.0.1" />
         <PackageReference Include="System.Resources.ResourceManager" Version="4.0.1" />
    -    <PackageReference Include="System.Runtime" Version="4.1.0" />
         <PackageReference Include="System.Runtime.Extensions" Version="4.1.0" />
         <PackageReference Include="System.Runtime.Handles" Version="4.0.1" />
         <PackageReference Include="System.Runtime.InteropServices" Version="4.1.0" />
    @@ -316,6 +315,9 @@
         <ErrorReport>prompt</ErrorReport>
         <CodeAnalysisRuleSet>MinimumRecommendedRules.ruleset</CodeAnalysisRuleSet>
       </PropertyGroup>
    +  <PropertyGroup>^M
    +    <AutoGenerateBindingRedirects>false</AutoGenerateBindingRedirects>^M
    +  </PropertyGroup>^M
       <Import Project="$(MSBuildBinPath)\Microsoft.CSharp.targets" />
       <Import Project="$(SolutionDir)\.nuget\NuGet.targets" Condition="Exists('$(SolutionDir)\.nuget\NuGet.targets')" />
       <Import Project="..\packages\Microsoft.Bcl.Build.1.0.14\tools\Microsoft.Bcl.Build.targets" Condition="Exists('..\packages\Microsoft.Bcl.Build.1.0.14\tools\Microsoft.Bcl.Build.targets')" />

- rebuild etc

## errors

    Compiler Error Message: CS0012: The type 'System.Object' is defined in an assembly that is not referenced. You must add a reference to assembly 'System.Runtime, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'.
