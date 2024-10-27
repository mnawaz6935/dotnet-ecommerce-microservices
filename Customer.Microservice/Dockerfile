# Use the official ASP.NET Core runtime as a parent image
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

# Use the SDK image to build the application
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Customer.Microservice/Customer.Microservice.csproj", "Customer.Microservice/"]
RUN dotnet restore "Customer.Microservice/Customer.Microservice.csproj"
COPY . .
WORKDIR "/src/Customer.Microservice"
RUN dotnet publish -c Release -o /app/publish

# Copy build results to the runtime container
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Customer.Microservice.dll"]
