﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BlazorCrudDotNet8.BusinessLogic.Entities;

public class ApplicationUserRole : IdentityUserRole<Guid>
{
    public ApplicationUser? ApplicationUserCreatedBy { get; set; }
    public ApplicationUser? ApplicationUserUpdatedBy { get; set; }
    public ApplicationUser? ApplicationUser { get; set; }
    public ApplicationRole? ApplicationRole { get; set; }
    public DateTime CreateDateTime { get; set; }
    public DateTime UpdateDateTime { get; set; }

    // ActualPropertyPlaceholder
}
