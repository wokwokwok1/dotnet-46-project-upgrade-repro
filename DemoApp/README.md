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

## errors

Same runtime error

## steps


