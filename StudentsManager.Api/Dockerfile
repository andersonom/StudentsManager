FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-stretch-slim AS base
WORKDIR /app
ENV ASPNETCORE_URLS=http://+:8089
EXPOSE 8089

FROM mcr.microsoft.com/dotnet/core/sdk:2.1-stretch AS build
WORKDIR /src
COPY ["StudentsManager.Api/StudentsManager.Api.csproj", "StudentsManager.Api/"]
COPY ["StudentsManager.Data/StudentsManager.Data.csproj", "StudentsManager.Data/"]
COPY ["StudentsManager.Domain/StudentsManager.Domain.csproj", "StudentsManager.Domain/"]
RUN dotnet restore "StudentsManager.Api/StudentsManager.Api.csproj"
COPY . .
WORKDIR "/src/StudentsManager.Api"
RUN dotnet build "StudentsManager.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "StudentsManager.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "StudentsManager.Api.dll"]
