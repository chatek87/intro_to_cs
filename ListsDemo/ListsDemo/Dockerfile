FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ListsDemo/ListsDemo.csproj", "ListsDemo/"]
RUN dotnet restore "ListsDemo/ListsDemo.csproj"
COPY . .
WORKDIR "/src/ListsDemo"
RUN dotnet build "ListsDemo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ListsDemo.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ListsDemo.dll"]
