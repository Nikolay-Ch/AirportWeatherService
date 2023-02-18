#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["AirportWeatherService/AirportWeatherService.csproj", "AirportWeatherService/"]
RUN dotnet restore "AirportWeatherService/AirportWeatherService.csproj"
COPY . .
WORKDIR "/src/AirportWeatherService"
RUN dotnet build "AirportWeatherService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AirportWeatherService.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

VOLUME ./config
VOLUME ./logs

ENTRYPOINT ["dotnet", "AirportWeatherService.dll"]
