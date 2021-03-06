# Demo.Core2.2

An example application for the EZNEW development framework

# Get Started

1. Download and install [.NetCore2.2 SDK](https://dotnet.microsoft.com/download/dotnet-core/2.2)
2. Download and install [Visual Studio 2019](https://visualstudio.microsoft.com/zh-hans/downloads/)
3. If you can't access nuget.org,you can use this nuget package source：<b>http://nuget.eznew.net/v3/index.json</b>
4. Clone or download project
5. Configure database connection in <b>Application/Site.Console/appsettings.json</b> and modify the database type in <b>Infrastructure/AppConfig.Database/DatabaseConfig</b>(The default value is DatabaseServerType.SQLServer)
6. Create database
	* [Create the database using EntityFramework Migration](https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli)(recommended)
	
		1. Open the command line tool(cmd.exe)
		
		2. Installing the tools：<b>dotnet tool install --global dotnet-ef</b>
		
		3. Navigate to the path to the <b>Application/App.EntityMigration</b> then run the command: <b>dotnet ef migrations add InitialCreate</b>
		
		4. Run the command：<b>dotnet ef database update</b>
		
	* [Download the database script to create the database](https://github.com/eznew-net/Demo.File/tree/master/DemoDataBase)
	
7. Build and run <b>Site.Console</b> 
8. Login by default UserName：<b>admin</b> and default Password：<b>admin</b>

# Reporting issues and bugs

If you have any questions or Suggestions, you can report to us via email,to the lidingbin@live.com, and we will reply to you as soon as possible, or you can contact [DingBin Li](https://github.com/lidingbin) via GitHub

# Related projects

These are some other repos for related projects:

  * [EZNEW](https://github.com/eznew-net/EZNEW)-A simple, easy-to-use, flexible, and efficient .NET development framework
  * [EZNEW.Data.SqlServer](https://github.com/eznew-net/EZNEW.Data.SqlServer)-Provides access to SQL Server databases based on the EZNEW development framework
  * [EZNEW.Data.MySQL](https://github.com/eznew-net/EZNEW.Data.MySQL)-Provides access to MySQL databases based on the EZNEW development framework
  * [EZNEW.Data.Oracle](https://github.com/eznew-net/EZNEW.Data.Oracle)-Provides access to Oracle databases based on the EZNEW development framework
  * [EZNEW.Web](https://github.com/eznew-net/EZNEW.Web)-ASP.NET development tool library
