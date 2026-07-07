using IdentityService.Domain.Entities;
using IdentityService.Infrastructure.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IdentityService.Infrastructure
{
  public static class DependencyInjection
  {
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
      var connectionString = configuration.GetConnectionString("IdentityDatabase");

      services.AddDbContext<AppIdentityDbContext>(options =>
      {
        options.UseNpgsql(connectionString);
      });

      services
          .AddIdentity<ApplicationUser, ApplicationRole>()
          .AddEntityFrameworkStores<AppIdentityDbContext>()
          .AddDefaultTokenProviders();

      return services;
    }
  }
}