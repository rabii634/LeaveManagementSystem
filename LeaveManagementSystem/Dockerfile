# Step 1: Use .NET SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy only the project file and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build the app
COPY . ./
RUN dotnet publish -c Release -o out

# Step 2: Use a smaller image to run the app
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# Copy compiled output from build image
COPY --from=build /app/out .

# Expose port 80 inside the container
EXPOSE 80

# Run the app when the container starts
ENTRYPOINT ["dotnet", "LeaveManagementSystem.dll"]

