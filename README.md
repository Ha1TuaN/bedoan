    # Build and Run the Project:
```bash
cd src/Host
dotnet build
dotnet run
```

# Migration Commands

## For TenantDbContext:
```bash
dotnet ef migrations add InitialMigrations --project .././Migrators/Migrators.MSSQL/ --context TenantDbContext -o Migrations/Tenant
dotnet ef database update --project .././Migrators/Migrators.MSSQL/ --context TenantDbContext
```

## For ApplicationDbContext:
```bash
dotnet ef migrations add InitialMigrations --project .././Migrators/Migrators.MSSQL/ --context ApplicationDbContext -o Migrations/Application
dotnet ef database update --project .././Migrators/Migrators.MSSQL/ --context ApplicationDbContext
```

## Generate SQL Script for Migrations:
```bash
dotnet ef migrations script {FROM_MIGRATION} {TO_MIGRATION} --context ApplicationDbContext -o ./script.sql
```

## Remove the Last Migration:
```bash
dotnet ef migrations remove --project .././Migrators/Migrators.MSSQL/ --context ApplicationDbContext
```
# Update the tools:
```bash
dotnet tool update --global dotnet-ef
```

# List migrations:
```bash
dotnet ef migrations list --project .././Migrators/Migrators.MSSQL/ --context ApplicationDbContext
```

# Pulish project
```bash
dotnet publish --configuration Release
```
# Install Tandan.OpenReport
## B1: Go to project Infrastructure
```bash
cd ../Infrastructure
```
## B2: Add source to nuget config
```bash
dotnet nuget add source http://10.10.10.220:8090/v3/index.json -n TanDanSource
### You can check installed source
dotnet nuget list source
```
## B3: Add Tandan.OpenReport
```bash
dotnet add package Tandan.OpenReport.Core --version 3.0.0
```

## Remove source
```bash
dotnet nuget remove source TanDanSource
```

# Lỗi không lọc các item đã xóa -> Kiểm tra trong ApplicationDbContext đã khai báo DbSet chưa
# Nếu ModelSnapshot không đồng bộ với database check trong Migrators.MSSQL.csproj