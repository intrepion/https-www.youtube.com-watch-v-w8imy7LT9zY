using Microsoft.AspNetCore.Identity;

namespace BlazorCrudDotNet8.BusinessLogic.Entities;

public class ApplicationUserToken : IdentityUserToken<string>
{
    public ApplicationUser? ApplicationUserUpdatedBy { get; set; }
}
