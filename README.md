# Migrations DB

1- Cmd to migrate database
```
 dotnet ef migrations add InitialIdentitySchema \
  --project IdentityService.Infrastructure \
  --startup-project IdentityService.Api \
  --context IdentityDbContext \
  --output-dir Persistence/Migrations
```

2- Cmd to update database
```
dotnet ef database update \
  --project IdentityService.Infrastructure \
  --startup-project IdentityService.Api \
  --context IdentityDbContext
```