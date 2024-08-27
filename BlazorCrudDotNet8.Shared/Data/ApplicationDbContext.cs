using BlazorCrudDotNet8.Shared.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudDotNet8.Shared.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<GameGuid> GameGuids { get; set; }
    public DbSet<GameInt> GameInts { get; set; }
    public DbSet<GameString> GameStrings { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        new GameGuidEntityTypeConfiguration().Configure(builder.Entity<GameGuid>());
        new GameIntEntityTypeConfiguration().Configure(builder.Entity<GameInt>());
        new GameStringEntityTypeConfiguration().Configure(builder.Entity<GameString>());
    }
}
