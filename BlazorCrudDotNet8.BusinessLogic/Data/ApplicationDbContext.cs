using BlazorCrudDotNet8.BusinessLogic.Entities;
using BlazorCrudDotNet8.BusinessLogic.Entities.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudDotNet8.BusinessLogic.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser, ApplicationRole, Guid, ApplicationUserClaim, ApplicationUserRole, ApplicationUserLogin, ApplicationRoleClaim, ApplicationUserToken>(options)
{
    public DbSet<Game> Games { get; set; }
    // DbSetCodePlaceholder

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        new ApplicationRoleClaimEntityTypeConfiguration().Configure(builder.Entity<ApplicationRoleClaim>());
        new ApplicationRoleEntityTypeConfiguration().Configure(builder.Entity<ApplicationRole>());
        new ApplicationUserEntityTypeConfiguration().Configure(builder.Entity<ApplicationUser>());
        new ApplicationUserClaimEntityTypeConfiguration().Configure(builder.Entity<ApplicationUserClaim>());
        new ApplicationUserLoginEntityTypeConfiguration().Configure(builder.Entity<ApplicationUserLogin>());
        new ApplicationUserRoleEntityTypeConfiguration().Configure(builder.Entity<ApplicationUserRole>());
        new ApplicationUserTokenEntityTypeConfiguration().Configure(builder.Entity<ApplicationUserToken>());
        new GameEntityTypeConfiguration().Configure(builder.Entity<Game>());
        // EntityTypeCfgCodePlaceholder
    }
}
