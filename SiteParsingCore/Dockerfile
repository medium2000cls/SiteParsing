FROM mcr.microsoft.com/dotnet/core/runtime:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["SiteParsingCore/SiteParsingCore.csproj", "SiteParsingCore/"]
RUN dotnet restore "SiteParsingCore/SiteParsingCore.csproj"
COPY . .
WORKDIR "/src/SiteParsingCore"
RUN dotnet build "SiteParsingCore.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SiteParsingCore.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SiteParsingCore.dll"]
