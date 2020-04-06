## To Trust Self Signed Dev Cert
```
dotnet dev-certs https -t
```
----

## To Create Sln Using CLI
```
dotnet new sln -n Example
```

## To Create WebApi Using CLI
```
dotnet new webapi -o Example.API
```

## Add Project to Sln File Using CLI
```
dotnet sln Example.sln add Example.API
```

## Create ClassLib Using CLI
```
dotnet classlib -o Example.Core
```

## Add ClassLib Reference To WebApi
```
dotnet add reference ..\Example.Core\
```
----