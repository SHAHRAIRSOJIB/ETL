1: OpenApi Project 
2: Connect your database(MS Sql Server) to the project
	2.1: in Appsetting.json 
	2.2: Go to SqlConnectionString (give your sql server information)
3: Do the migration from Nuget Package Manager
(must change the project to ExelTechApi.service then in Nuget Package Manager run this Command(add-migration initial -o Model/Migrations) then run commad(Update-database))
its will create database table.
4: Then Run the api project.
5 : Run UI Project
