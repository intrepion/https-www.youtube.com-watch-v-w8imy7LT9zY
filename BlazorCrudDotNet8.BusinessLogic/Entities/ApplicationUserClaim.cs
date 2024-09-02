using Microsoft.AspNetCore.Identity;

namespace BlazorCrudDotNet8.BusinessLogic.Entities;

public class ApplicationUserClaim : IdentityUserClaim<string>
{
    public ApplicationUser? ApplicationUserUpdatedBy { get; set; }
}
