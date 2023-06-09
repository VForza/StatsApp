FROM mcr.microsoft.com/dotnet/sdk: 5.0 AS build-env
WORKDIR /app
EXPOSE 80
EXPOSE 443

COPY *.csproj ./
RUN dotnet restore

COPY . ./
RUN	dotnet publish -c Release -o out

