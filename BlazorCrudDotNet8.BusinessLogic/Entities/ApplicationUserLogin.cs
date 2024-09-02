using Microsoft.AspNetCore.Identity;

namespace BlazorCrudDotNet8.BusinessLogic.Entities;

public class ApplicationUserLogin : IdentityUserLogin<string>
{
    public ApplicationUser? ApplicationUserUpdatedBy { get; set; }
}
