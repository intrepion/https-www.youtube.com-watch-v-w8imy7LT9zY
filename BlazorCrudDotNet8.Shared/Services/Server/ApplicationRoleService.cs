using BlazorCrudDotNet8.Shared.Data;
using BlazorCrudDotNet8.Shared.Entities;
using BlazorCrudDotNet8.Shared.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudDotNet8.Shared.Services.Server;

public class ApplicationRoleService(ApplicationDbContext applicationDbContext) : IApplicationRoleService
{
    private readonly ApplicationDbContext _applicationDbContext = applicationDbContext;

    public async Task<ApplicationRole> AddAsync(ApplicationRole applicationRole)
    {
        _applicationDbContext.Roles.Add(applicationRole);
        await _applicationDbContext.SaveChangesAsync();

        return applicationRole;
    }

    public async Task<bool> DeleteAsync(string id)
    {
        var dbApplicationRole = await _applicationDbContext.Roles.FindAsync(id);

        if (dbApplicationRole == null)
        {
            return false;
        }

        _applicationDbContext.Remove(dbApplicationRole);
        await _applicationDbContext.SaveChangesAsync();

        return true;
    }

    public async Task<ApplicationRole> EditAsync(string id, ApplicationRole applicationRole)
    {
        var dbApplicationRole = await _applicationDbContext.Roles.FindAsync(id);

        if (dbApplicationRole == null)
        {
            throw new Exception("Game guid not found.");
        }

        dbApplicationRole.Name = applicationRole.Name;
        await _applicationDbContext.SaveChangesAsync();

        return dbApplicationRole;
    }

    public async Task<List<ApplicationRole>> GetAllAsync()
    {
        var applicationRoles = await _applicationDbContext.Roles.ToListAsync();

        return applicationRoles;
    }

    public async Task<ApplicationRole> GetByIdAsync(string id)
    {
        return await _applicationDbContext.Roles.FindAsync(id);
    }
}
