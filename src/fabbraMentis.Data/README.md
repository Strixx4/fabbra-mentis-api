## Installing image in Docker:
```bash
docker pull mcr.microsoft.com/mssql/server:2022-latest 
```

## Running Container:
```bash
docker run -d --name fam-local -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=localhost!Fam' -p 1433:1433 mcr.microsoft.com/mssql/server:2022-latest
```

### Stringa per connettersi al DB:
Server=localhost,1433;Database=fam-local;User Id=sa;Password=localhost!Fam;TrustServerCertificate=True

## Creare una Migrazione:
dotnet ef migrations add Profiler.<MigrationName> --msbuildprojectextensionspath ../../artifacts/obj/${PWD##*/}

## Aggiornamento DB aggiunta migrazione
dotnet ef database update

## Far tornare il db ad una specifica versione
dotnet ef database update <NAME>

## Eliminare una Migration:
dotnet ef migrations remove