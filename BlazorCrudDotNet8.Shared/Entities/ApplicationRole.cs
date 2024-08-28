﻿using Microsoft.AspNetCore.Identity;

namespace BlazorCrudDotNet8.Shared.Entities;

public class ApplicationRole : IdentityRole
{
    public ApplicationUser? ApplicationUserUpdatedBy { get; set; }
}
