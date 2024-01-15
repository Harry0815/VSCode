- Infos zu .NET
----------------------------------------------------------------
  .NET SDK 8.0 installieren

Ausführen folgender Befehle:

- Installieren LibMan
----------------------------------------------------------------
  dotnet tool uninstall -g Microsoft.Web.LibraryManager.Cli
  dotnet tool install -g Microsoft.Web.LibraryManager.Cli

- Erstellen einer neuen APP unter .NET
----------------------------------------------------------------
  dotnet new <Typ der Anwendung z.b.: webapp,console etc> -o <Name der Anwendung>
 