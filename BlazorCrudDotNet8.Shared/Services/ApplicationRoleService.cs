﻿using BlazorCrudDotNet8.Shared.Data;
using BlazorCrudDotNet8.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudDotNet8.Shared.Services;

public class ApplicationRoleService : IApplicationRoleService
{
    private readonly ApplicationDbContext _applicationDbContext;

    public ApplicationRoleService(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }

    public async Task<List<ApplicationRole>> GetAllAsync()
    {
        var applicationRoles = await _applicationDbContext.Roles.ToListAsync();

        return applicationRoles;
    }
}
