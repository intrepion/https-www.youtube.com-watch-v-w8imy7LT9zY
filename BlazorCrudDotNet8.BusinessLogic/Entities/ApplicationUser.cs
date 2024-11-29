﻿using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BlazorCrudDotNet8.BusinessLogic.Entities;

public class ApplicationUser : IdentityUser<Guid>
{
    public ICollection<ApplicationUserRole> ApplicationUserRoles { get; set; } = [];
    public ApplicationUser? ApplicationUserCreatedBy { get; set; }
    public ApplicationUser? ApplicationUserUpdatedBy { get; set; }
    public DateTime CreateDateTime { get; set; }
    public ICollection<ApplicationRole> CreatedApplicationRoles { get; set; } = [];
    public ICollection<ApplicationRoleClaim> CreatedApplicationRoleClaims { get; set; } = [];
    public ICollection<ApplicationUser> CreatedApplicationUsers { get; set; } = [];
    public ICollection<ApplicationUserClaim> CreatedApplicationUserClaims { get; set; } = [];
    public ICollection<ApplicationUserLogin> CreatedApplicationUserLogins { get; set; } = [];
    public ICollection<ApplicationUserRole> CreatedApplicationUserRoles { get; set; } = [];
    public ICollection<ApplicationUserToken> CreatedApplicationUserTokens { get; set; } = [];
    public DateTime UpdateDateTime { get; set; }
    public ICollection<ApplicationRole> UpdatedApplicationRoles { get; set; } = [];
    public ICollection<ApplicationRoleClaim> UpdatedApplicationRoleClaims { get; set; } = [];
    public ICollection<ApplicationUser> UpdatedApplicationUsers { get; set; } = [];
    public ICollection<ApplicationUserClaim> UpdatedApplicationUserClaims { get; set; } = [];
    public ICollection<ApplicationUserLogin> UpdatedApplicationUserLogins { get; set; } = [];
    public ICollection<ApplicationUserRole> UpdatedApplicationUserRoles { get; set; } = [];
    public ICollection<ApplicationUserToken> UpdatedApplicationUserTokens { get; set; } = [];

    public ICollection<Game> CreatedGames { get; set; } = [];
    public ICollection<Game> UpdatedGames { get; set; } = [];
    // ActualPropertyPlaceholder
}
