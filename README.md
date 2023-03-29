# BACKEND
$ dotnet add package Microsoft.EntityFrameworkCore
$ dotnet add package Microsoft.EntityFrameworkCore.Relational
$ dotnet add package Microsoft.EntityFrameworkCore.Tools
$ dotnet add package Microsoft.EntityFrameworkCore.SqlServer


$ dotnet ef migrations add Pessoas
$ dotnet ef database update

# FRONTEND
$ npm add ngx-bootstrap


# BANCO DE DADOS
## Subir container
docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=123456' -e 'MSSQL_PID=Express' -p 1433:1433 -d mcr.microsoft.com/mssql/server:2017-latest-ubuntu 
 
## Entrar container
docker ps 
## Pegar o id do container (7ca2b77828d5)
docker exec -it 7ca2b77828d5 /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P 123456

## Alguns comandos de teste
CREATE DATABASE producao
go
SELECT Name from sys.Databases
go
USE TestDB
go
CREATE TABLE Inventory (id INT, name NVARCHAR(50), quantity INT)
go
INSERT INTO Inventory VALUES (1, 'banana', 150); INSERT INTO Inventory VALUES (2, 'orange', 154);
go
SELECT * FROM Inventory WHERE quantity > 152;



