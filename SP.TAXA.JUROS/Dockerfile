FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["SP.TAXA.JUROS/SP.TAXA.JUROS.csproj", "SP.TAXA.JUROS/"]
RUN dotnet restore "SP.TAXA.JUROS/SP.TAXA.JUROS.csproj"
COPY . .
WORKDIR "/src/SP.TAXA.JUROS"
RUN dotnet build "SP.TAXA.JUROS.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SP.TAXA.JUROS.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SP.TAXA.JUROS.dll"]