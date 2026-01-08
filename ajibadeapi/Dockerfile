# =========================
# Build Stage
# =========================
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy project files
COPY . .

# Restore and publish
RUN dotnet restore
RUN dotnet publish -c Release -o /app/publish

# =========================
# Runtime Stage
# =========================
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# Copy published output
COPY --from=build /app/publish .

# Expose port
EXPOSE 8080

# Start application
ENTRYPOINT ["dotnet", "ajibadeapi.dll"]
