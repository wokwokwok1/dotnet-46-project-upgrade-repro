# Steps taken

## steps

- retareget to .net 4.7.2
- delete packages, bin, obj
- rebuild solution

## error

    Severity	Code	Description	Project	File	Line	Suppression State
    Error		Some NuGet packages were installed using a target framework different from the current target framework and may need to be reinstalled. Visit http://docs.nuget.org/docs/workflows/reinstalling-packages for more information.  Packages affected: Microsoft.Web.RedisSessionStateProvider, System.AppContext, System.ComponentModel.TypeConverter, System.IO, System.Linq, System.Linq.Expressions, System.Reflection, System.Runtime, System.Runtime.Extensions, System.Runtime.InteropServices, System.Security.Cryptography.Algorithms, System.Security.Cryptography.X509Certificates	DemoApp		0	

    Severity	Code	Description	Project	File	Line	Suppression State
    Warning		Found conflicts between different versions of the same dependent assembly. In Visual Studio, double-click this warning (or select it and press Enter) to fix the conflicts; otherwise, add the following binding redirects to the "runtime" node in the application configuration file: <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1"><dependentAssembly><assemblyIdentity name="System.Net.Http" culture="neutral" publicKeyToken="b03f5f7f11d50a3a" /><bindingRedirect oldVersion="0.0.0.0-4.2.0.0" newVersion="4.2.0.0" /></dependentAssembly></assemblyBinding><assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1"><dependentAssembly><assemblyIdentity name="System.Runtime" culture="neutral" publicKeyToken="b03f5f7f11d50a3a" /><bindingRedirect oldVersion="0.0.0.0-4.1.2.0" newVersion="4.1.2.0" /></dependentAssembly></assemblyBinding>	DemoApp			

## steps

- double click warning, update web.config
- delete packages, bin, obj
- rebuild solution

## error

    Severity	Code	Description	Project	File	Line	Suppression State
    Error		Some NuGet packages were installed using a target framework different from the current target framework and may need to be reinstalled. Visit http://docs.nuget.org/docs/workflows/reinstalling-packages for more information.  Packages affected: Microsoft.Web.RedisSessionStateProvider, System.AppContext, System.ComponentModel.TypeConverter, System.IO, System.Linq, System.Linq.Expressions, System.Reflection, System.Runtime, System.Runtime.Extensions, System.Runtime.InteropServices, System.Security.Cryptography.Algorithms, System.Security.Cryptography.X509Certificates	DemoApp		0	

runtime error:

    Server Error in '/' Application.
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

    [FileNotFoundException: Could not load file or assembly 'System.Runtime, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' or one of its dependencies. The system cannot find the file specified.]
       System.ModuleHandle.ResolveType(RuntimeModule module, Int32 typeToken, IntPtr* typeInstArgs, Int32 typeInstCount, IntPtr* methodInstArgs, Int32 methodInstCount, ObjectHandleOnStack type) +0
       System.ModuleHandle.ResolveTypeHandleInternal(RuntimeModule module, Int32 typeToken, RuntimeTypeHandle[] typeInstantiationContext, RuntimeTypeHandle[] methodInstantiationContext) +191
       System.Reflection.RuntimeModule.ResolveType(Int32 metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments) +161
       System.Reflection.CustomAttribute.FilterCustomAttributeRecord(CustomAttributeRecord caRecord, MetadataImport scope, Assembly& lastAptcaOkAssembly, RuntimeModule decoratedModule, MetadataToken decoratedToken, RuntimeType attributeFilterType, Boolean mustBeInheritable, Object[] attributes, IList derivedAttributes, RuntimeType& attributeType, IRuntimeMethodInfo& ctor, Boolean& ctorHasParameters, Boolean& isVarArg) +155
       System.Reflection.CustomAttribute.GetCustomAttributes(RuntimeModule decoratedModule, Int32 decoratedMetadataToken, Int32 pcaCount, RuntimeType attributeFilterType, Boolean mustBeInheritable, IList derivedAttributes, Boolean isDecoratedTargetSecurityTransparent) +607
       System.Reflection.CustomAttribute.GetCustomAttributes(RuntimeAssembly assembly, RuntimeType caType) +144
       Owin.Loader.DefaultLoader.SearchForStartupAttribute(String friendlyName, IList`1 errors, Boolean& conflict) +190
       Owin.Loader.DefaultLoader.GetDefaultConfiguration(String friendlyName, IList`1 errors) +68
       Owin.Loader.DefaultLoader.LoadImplementation(String startupName, IList`1 errorDetails) +89
       Owin.Loader.DefaultLoader.Load(String startupName, IList`1 errorDetails) +30
       Microsoft.Owin.Host.SystemWeb.OwinBuilder.GetAppStartup() +165
       Microsoft.Owin.Host.SystemWeb.OwinHttpModule.InitializeBlueprint() +37
       System.Threading.LazyInitializer.EnsureInitializedCore(T& target, Boolean& initialized, Object& syncLock, Func`1 valueFactory) +135
       Microsoft.Owin.Host.SystemWeb.OwinHttpModule.Init(HttpApplication context) +160
       System.Web.HttpApplication.RegisterEventSubscriptionsWithIIS(IntPtr appContext, HttpContext context, MethodInfo[] handlers) +581
       System.Web.HttpApplication.InitSpecial(HttpApplicationState state, MethodInfo[] handlers, IntPtr appContext, HttpContext context) +168
       System.Web.HttpApplicationFactory.GetSpecialApplicationInstance(IntPtr appContext, HttpContext context) +277
       System.Web.Hosting.PipelineRuntime.InitializeApplication(IntPtr appContext) +369

## steps

- remove all assembly bindings from web.config
- build solution

## error

    Severity	Code	Description	Project	File	Line	Suppression State
    Error		Some NuGet packages were installed using a target framework different from the current target framework and may need to be reinstalled. Visit http://docs.nuget.org/docs/workflows/reinstalling-packages for more information.  Packages affected: Microsoft.Web.RedisSessionStateProvider, System.AppContext, System.ComponentModel.TypeConverter, System.IO, System.Linq, System.Linq.Expressions, System.Reflection, System.Runtime, System.Runtime.Extensions, System.Runtime.InteropServices, System.Security.Cryptography.Algorithms, System.Security.Cryptography.X509Certificates	DemoApp		0	

    Severity	Code	Description	Project	File	Line	Suppression State
    Warning		Found conflicts between different versions of the same dependent assembly. In Visual Studio, double-click this warning (or select it and press Enter) to fix the conflicts; otherwise, add the following binding redirects to the "runtime" node in the application configuration file: <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1"><dependentAssembly><assemblyIdentity name="Antlr3.Runtime" culture="neutral" publicKeyToken="eb42632606e9261f" /><bindingRedirect oldVersion="0.0.0.0-3.5.0.2" newVersion="3.5.0.2" /></dependentAssembly></assemblyBinding><assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1"><dependentAssembly><assemblyIdentity name="Common.Logging" culture="neutral" publicKeyToken="af08829b84f0328e" /><bindingRedirect oldVersion="0.0.0.0-3.3.0.0" newVersion="3.3.0.0" /></dependentAssembly></assemblyBinding><assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1"><dependentAssembly><assemblyIdentity name="log4net" culture="neutral" publicKeyToken="669e0ddf0bb1aa2a" /><bindingRedirect oldVersion="0.0.0.0-2.0.8.0" newVersion="2.0.8.0" /></dependentAssembly></assemblyBinding><assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1"><dependentAssembly><assemblyIdentity name="Microsoft.IdentityModel.Protocol.Extensions" culture="neutral" publicKeyToken="31bf3856ad364e35" /><bindingRedirect oldVersion="0.0.0.0-1.0.2.33" newVersion="1.0.2.33" /></dependentAssembly></assemblyBinding><assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1"><dependentAssembly><assemblyIdentity name="Microsoft.Owin" culture="neutral" publicKeyToken="31bf3856ad364e35" /><bindingRedirect oldVersion="0.0.0.0-3.1.0.0" newVersion="3.1.0.0" /></dependentAssembly></assemblyBinding><assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1"><dependentAssembly><assemblyIdentity name="Newtonsoft.Json" culture="neutral" publicKeyToken="30ad4fe6b2a6aeed" /><bindingRedirect oldVersion="0.0.0.0-10.0.0.0" newVersion="10.0.0.0" /></dependentAssembly></assemblyBinding><assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1"><dependentAssembly><assemblyIdentity name="System.Collections.Immutable" culture="neutral" publicKeyToken="b03f5f7f11d50a3a" /><bindingRedirect oldVersion="0.0.0.0-1.2.0.0" newVersion="1.2.0.0" /></dependentAssembly></assemblyBinding><assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1"><dependentAssembly><assemblyIdentity name="System.Data.SqlClient" culture="neutral" publicKeyToken="b03f5f7f11d50a3a" /><bindingRedirect oldVersion="0.0.0.0-4.1.0.0" newVersion="4.1.0.0" /></dependentAssembly></assemblyBinding><assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1"><dependentAssembly><assemblyIdentity name="System.IdentityModel.Tokens.Jwt" culture="neutral" publicKeyToken="31bf3856ad364e35" /><bindingRedirect oldVersion="0.0.0.0-4.0.20622.1351" newVersion="4.0.20622.1351" /></dependentAssembly></assemblyBinding><assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1"><dependentAssembly><assemblyIdentity name="System.Net.Http.Formatting" culture="neutral" publicKeyToken="31bf3856ad364e35" /><bindingRedirect oldVersion="0.0.0.0-5.2.3.0" newVersion="5.2.3.0" /></dependentAssembly></assemblyBinding><assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1"><dependentAssembly><assemblyIdentity name="System.Reflection.Metadata" culture="neutral" publicKeyToken="b03f5f7f11d50a3a" /><bindingRedirect oldVersion="0.0.0.0-1.3.0.0" newVersion="1.3.0.0" /></dependentAssembly></assemblyBinding><assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1"><dependentAssembly><assemblyIdentity name="System.Web.Http" culture="neutral" publicKeyToken="31bf3856ad364e35" /><bindingRedirect oldVersion="0.0.0.0-5.2.3.0" newVersion="5.2.3.0" /></dependentAssembly></assemblyBinding><assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1"><dependentAssembly><assemblyIdentity name="System.Web.Mvc" culture="neutral" publicKeyToken="31bf3856ad364e35" /><bindingRedirect oldVersion="0.0.0.0-5.2.3.0" newVersion="5.2.3.0" /></dependentAssembly></assemblyBinding><assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1"><dependentAssembly><assemblyIdentity name="WebGrease" culture="neutral" publicKeyToken="31bf3856ad364e35" /><bindingRedirect oldVersion="0.0.0.0-1.6.5135.21930" newVersion="1.6.5135.21930" /></dependentAssembly></assemblyBinding>	DemoApp			

## steps

- double click on warning, update web.config
- delete packages, bin, obj
- rebuild solution

## error

    Severity	Code	Description	Project	File	Line	Suppression State
    Error		Some NuGet packages were installed using a target framework different from the current target framework and may need to be reinstalled. Visit http://docs.nuget.org/docs/workflows/reinstalling-packages for more information.  Packages affected: Microsoft.Web.RedisSessionStateProvider, System.AppContext, System.ComponentModel.TypeConverter, System.IO, System.Linq, System.Linq.Expressions, System.Reflection, System.Runtime, System.Runtime.Extensions, System.Runtime.InteropServices, System.Security.Cryptography.Algorithms, System.Security.Cryptography.X509Certificates	DemoApp		0	

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

:(
