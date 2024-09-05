using Microsoft.AspNetCore.Identity;

namespace BlazorCrudDotNet8.BusinessLogic.Entities;

public class ApplicationRoleClaim : IdentityRoleClaim<string>
{
    public ApplicationUser? ApplicationUserUpdatedBy { get; set; }
}
