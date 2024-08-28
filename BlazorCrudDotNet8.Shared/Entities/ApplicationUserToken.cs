using Microsoft.AspNetCore.Identity;

namespace BlazorCrudDotNet8.Shared.Entities;

public class ApplicationUserToken : IdentityUserToken<string>
{
    public ApplicationUser? ApplicationUserUpdatedBy { get; set; }
}
