using Microsoft.AspNetCore.Identity;

namespace BlazorCrudDotNet8.Shared.Entities;

public class ApplicationRoleClaim : IdentityRoleClaim<string>
{
    public ApplicationUser? ApplicationUserUpdatedBy { get; set; }
}
