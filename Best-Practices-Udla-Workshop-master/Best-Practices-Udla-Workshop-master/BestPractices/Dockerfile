# Imagen base para construir
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o out

# Imagen base para ejecutar
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app/out .

# Configurar el puerto que usará Render
ENV ASPNETCORE_URLS=http://+:80
EXPOSE 80

# Comando para iniciar 
ENTRYPOINT ["dotnet", "BestPractices.dll"]