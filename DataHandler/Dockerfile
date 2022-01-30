FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DataHandler/DataHandler.csproj", "DataHandler/"]
RUN dotnet restore "DataHandler/DataHandler.csproj"
COPY . .
WORKDIR "/src/DataHandler"
RUN dotnet build "DataHandler.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DataHandler.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DataHandler.dll"]
