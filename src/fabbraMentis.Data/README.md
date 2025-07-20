## Installing image in Docker:
```bash
docker pull mcr.microsoft.com/mssql/server:2022-latest 
```

## Running Container:
```bash
docker run -d --name fam-local -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=lh' -p 1433:1433 mcr.microsoft.com/mssql/server:2022-latest
```

## Creare una Migrazione:
dotnet ef migrations add Profiler.<MigrationName> --msbuildprojectextensionspath ../../artifacts/obj/${PWD##*/}

## Aggiornamento DB aggiunta migrazione
dotnet ef database update

## Far tornare il db ad una specifica versione
dotnet ef database update <NAME>

## Eliminare una Migration:
dotnet ef migrations remove