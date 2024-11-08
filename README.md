# BlazorCrudDotNet8

## Build

dotnet build

## Update database

```bash
dotnet tool install --global dotnet-ef
dotnet ef --project BlazorCrudDotNet8.BusinessLogic --startup-project BlazorCrudDotNet8 database update
```

## Run

```bash
dotnet run --project BlazorCrudDotNet8
```

## Test

### terminal window 1

```bash
dotnet tool install --global PowerShell
cd BlazorCrudDotNet8.AcceptanceTests
pwsh ./bin/Debug/net8.0/playwright.ps1 install --with-deps
cd ..
dotnet run --environment Test --project BlazorCrudDotNet8 --urls http://localhost:8765
```

### terminal window 2

```bash
BASE_URL=http://localhost:8765 HEADED=1 dotnet test
```
