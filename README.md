# LeaveManagementSystem API 
   A Dockerized ASP.NET Core Web API to manage employee leave requests with filtering, pagination, reporting, and business rules.
## Tech Stack
- ASP.NET Core 8.0
- Entity Framework Core (Code First)
- SQLite
- Swagger for API testing
- Dockerfile
## Run Locally (Without Docker)
- dotnet restore
- dotnet ef database update
- dotnet run
- visit : http://localhost:5080/swagger
## Run with docker 
- docker build -t leave-api .
- docker run -d -p 5050:8080 -e ASPNETCORE_ENVIRONMENT=Development leave-api
- visit : http://localhost:5050/swagger
