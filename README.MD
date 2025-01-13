First steps playing about with Blazor Server.

Endpoint code and front end both in the .razor file

Scaffolding an Entity Model into pages and various things can be done with a command such as the following:-

-m is the Model, e.g Employee in this example
-dbProvider has to be Postgres because MySql/MariaDB isn't supported for this purpose, and fancied a change.

dotnet aspnet-codegenerator blazor CRUD -dbProvider postgres -dc EmployeeManager.Data.EmployeeManagerDbContext -m Employee -outDir Components/Pages

For more info: https://learn.microsoft.com/en-us/aspnet/core/blazor/tutorials/movie-database-app/part-2?view=aspnetcore-9.0&pivots=vsc