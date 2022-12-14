FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MethodsDemo/MethodsDemo.csproj", "MethodsDemo/"]
RUN dotnet restore "MethodsDemo/MethodsDemo.csproj"
COPY . .
WORKDIR "/src/MethodsDemo"
RUN dotnet build "MethodsDemo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MethodsDemo.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MethodsDemo.dll"]
