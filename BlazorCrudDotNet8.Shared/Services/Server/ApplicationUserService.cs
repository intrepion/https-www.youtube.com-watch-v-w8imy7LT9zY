using BlazorCrudDotNet8.Shared.Data;
using BlazorCrudDotNet8.Shared.Entities;
using BlazorCrudDotNet8.Shared.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudDotNet8.Shared.Services.Server;

public class ApplicationUserService(ApplicationDbContext applicationDbContext) : IApplicationUserService
{
    private readonly ApplicationDbContext _applicationDbContext = applicationDbContext;

    public async Task<ApplicationUser> AddAsync(ApplicationUser applicationUser)
    {
        _applicationDbContext.Users.Add(applicationUser);
        await _applicationDbContext.SaveChangesAsync();

        return applicationUser;
    }

    public async Task<bool> DeleteAsync(string id)
    {
        var dbApplicationUser = await _applicationDbContext.Users.FindAsync(id);

        if (dbApplicationUser == null)
        {
            return false;
        }

        _applicationDbContext.Remove(dbApplicationUser);
        await _applicationDbContext.SaveChangesAsync();

        return true;
    }

    public async Task<ApplicationUser> EditAsync(string id, ApplicationUser applicationUser)
    {
        var dbApplicationUser = await _applicationDbContext.Users.FindAsync(id);

        if (dbApplicationUser == null)
        {
            throw new Exception("Game guid not found.");
        }

        dbApplicationUser.Email = applicationUser.Email;
        await _applicationDbContext.SaveChangesAsync();

        return dbApplicationUser;
    }

    public async Task<List<ApplicationUser>> GetAllAsync()
    {
        var applicationUsers = await _applicationDbContext.Users.ToListAsync();

        return applicationUsers;
    }

    public async Task<ApplicationUser> GetByIdAsync(string id)
    {
        return await _applicationDbContext.Users.FindAsync(id);
    }
}
