using Microsoft.AspNetCore.Identity;

namespace AppNamePlaceholder.Shared.Entities;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public ApplicationUser? ApplicationUserUpdatedBy { get; set; }
    public ICollection<ApplicationRole>? UpdatedApplicationRoles { get; set; }
    public ICollection<ApplicationUser>? UpdatedApplicationUsers { get; set; }
}
