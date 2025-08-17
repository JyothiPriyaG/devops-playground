FROM mcr.microsoft.com/dotnet/sdk:8.0 as build
WORKDIR /app
COPY *.cs *.csproj /app/sampleApp/
RUN dotnet restore /app/sampleApp/sampleApp.csproj
RUN dotnet publish "/app/sampleApp/sampleApp.csproj" -c Release -o /app/build/
ENTRYPOINT [ "dotnet", "sampleApp.dll"]

FROM mcr.microsoft.com/dotnet/runtime:8.0 as final
WORKDIR /src
COPY --from=build /app/build/ /src/sampleApp
ENTRYPOINT [ "dotnet", "/src/sampleApp/sampleApp.dll" ]