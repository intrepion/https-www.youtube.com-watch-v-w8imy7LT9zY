using BlazorCrudDotNet8.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudDotNet8.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<GameGuid> GameGuids { get; set; }
    public DbSet<GameInt> GameInts { get; set; }
    public DbSet<GameString> GameStrings { get; set; }
}
