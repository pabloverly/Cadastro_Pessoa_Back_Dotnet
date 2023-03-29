#BACKEND
$ dotnet add package Microsoft.EntityFrameworkCore
$ dotnet add package Microsoft.EntityFrameworkCore.Relational
$ dotnet add package Microsoft.EntityFrameworkCore.Tools
$ dotnet add package Microsoft.EntityFrameworkCore.SqlServer


$ dotnet ef migrations add Pessoas
$ dotnet ef database update

#FRONTEND
$ npm add ngx-bootstrap