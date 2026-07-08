using IdentityService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace IdentityService.Infrastructure.Persistence
{
  public class AppIdentityDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
  {
    public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options): base(options) {}
  }
}