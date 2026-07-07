using Microsoft.AspNetCore.Identity;

namespace IdentityService.Domain.Entities
{
  public class ApplicationUser : IdentityUser<Guid>
  {
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateTime CreateAtUTC { get; set; } = DateTime.UtcNow;
  }
}