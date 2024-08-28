using Microsoft.AspNetCore.Identity;

namespace BlazorCrudDotNet8.Shared.Entities;

public class ApplicationUserClaim : IdentityUserClaim<string>
{
    public ApplicationUser? ApplicationUserUpdatedBy { get; set; }
}
