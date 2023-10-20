#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["4.API/4.API.csproj", "4.API/"]
COPY ["3.Infra/3.Infra.csproj", "3.Infra/"]
COPY ["2.Core/2.Core.csproj", "2.Core/"]
COPY ["1.Domain/1.Domain.csproj", "1.Domain/"]
RUN dotnet restore "4.API/4.API.csproj"
COPY . .
WORKDIR "/src/4.API"
RUN dotnet build "4.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "4.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "4.API.dll"]