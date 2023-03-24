FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["JWT-Basic-Implementation/JWT-Basic-Implementation.csproj", "JWT-Basic-Implementation/"]
RUN dotnet restore "JWT-Basic-Implementation/JWT-Basic-Implementation.csproj"
COPY . .
WORKDIR "/src/JWT-Basic-Implementation"
RUN dotnet build "JWT-Basic-Implementation.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "JWT-Basic-Implementation.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "JWT-Basic-Implementation.dll"]
