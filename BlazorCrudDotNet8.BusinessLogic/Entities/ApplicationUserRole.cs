﻿using Microsoft.AspNetCore.Identity;

namespace BlazorCrudDotNet8.BusinessLogic.Entities;

public class ApplicationUserRole : IdentityUserRole<Guid>
{
    public ApplicationUser? ApplicationUserUpdatedBy { get; set; }
    public ApplicationUser? ApplicationUser { get; set; }
    public ApplicationRole? ApplicationRole { get; set; }
}
