# add base image
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /app

COPY . .

RUN dotnet clean ./P2-ConnectFourBackEnd.sln
RUN dotnet publish ./Connect4API --configuration Release -o ./publish

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS run

WORKDIR /app

COPY --from=build /app/publish .

CMD ["dotnet", "Connect4API.dll"]