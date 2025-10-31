Student Performance Tracker System

For admin page: localhost:5179/admin
username : admin
password : password123

//installing dotnet in vscode
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design

//create migrations
dotnet ef migrations add <migrationName>

//apply migration to database
dotnet ef database update

//remove last migration
dotnet ef migrations remove
