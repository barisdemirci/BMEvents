FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["src/ServiceLayer/BMEvents.WebApi/BMEvents.WebApi.csproj", "src/ServiceLayer/BMEvents.WebApi/"]
RUN dotnet restore "src/ServiceLayer/BMEvents.WebApi/BMEvents.WebApi.csproj"
COPY . .
WORKDIR "/src/src/ServiceLayer/BMEvents.WebApi"
RUN dotnet build "BMEvents.WebApi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "BMEvents.WebApi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "BMEvents.WebApi.dll"]