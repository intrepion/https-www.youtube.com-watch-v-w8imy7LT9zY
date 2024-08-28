using Microsoft.AspNetCore.Identity;

namespace BlazorCrudDotNet8.Shared.Entities;

public class ApplicationUserLogin : IdentityUserLogin<string>
{
    public ApplicationUser? ApplicationUserUpdatedBy { get; set; }
}
