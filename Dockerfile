FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /AJWTEST

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /AJWTEST
COPY --from=build-env /AJWTEST/out .
ENTRYPOINT ["dotnet", "AJWTEST.dll"]