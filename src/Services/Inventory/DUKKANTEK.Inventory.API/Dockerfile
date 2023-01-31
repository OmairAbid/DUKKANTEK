#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

# Copy the necessary project files
COPY ["Services/Inventory/DUKKANTEK.Inventory.Domain/DUKKANTEK.Inventory.Domain.csproj", "Services/Inventory/DUKKANTEK.Inventory.Domain/"]
COPY ["Services/Inventory/DUKKANTEK.Inventory.Infrastructure/DUKKANTEK.Inventory.Infrastructure.csproj", "Services/Inventory/DUKKANTEK.Inventory.Infrastructure/"]
COPY ["Services/Inventory/DUKKANTEK.Inventory.Application/Application.Commands.csproj", "Services/Inventory/DUKKANTEK.Inventory.Application/"]
COPY ["Services/Inventory/DUKKANTEK.Inventory.API/DUKKANTEK.Inventory.API.csproj", "Services/Inventory/DUKKANTEK.Inventory.API/"]
RUN dotnet restore "Services/Inventory/DUKKANTEK.Inventory.API/DUKKANTEK.Inventory.API.csproj"
COPY . .
WORKDIR "/src/Services/Inventory/DUKKANTEK.Inventory.API"
RUN dotnet build "DUKKANTEK.Inventory.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DUKKANTEK.Inventory.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DUKKANTEK.Inventory.API.dll"]