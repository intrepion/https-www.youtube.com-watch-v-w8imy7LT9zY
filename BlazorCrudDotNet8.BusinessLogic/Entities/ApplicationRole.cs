using Microsoft.AspNetCore.Identity;

namespace BlazorCrudDotNet8.BusinessLogic.Entities;

public class ApplicationRole : IdentityRole
{
    public ICollection<ApplicationUserRole> ApplicationUserRoles { get; set; } = [];
    public ApplicationUser? ApplicationUserUpdatedBy { get; set; }
}
