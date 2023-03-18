FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY . .
RUN dotnet restore "CleanArchitectureExample.Web/CleanArchitectureExample.Web.csproj"
RUN dotnet publish "CleanArchitectureExample.Web/CleanArchitectureExample.Web.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "CleanArchitectureExample.Web.dll"]
