using BlazorCrudDotNet8.Shared.Data;
using BlazorCrudDotNet8.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudDotNet8.Shared.Services;

public class ClassNamePlaceholderService : IClassNamePlaceholderService
{
    private readonly ApplicationDbContext _applicationDbContext;

    public ClassNamePlaceholderService(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }

    public async Task<List<ClassNamePlaceholder>> GetAllAsync()
    {
        var objectNamePlaceholders = await _applicationDbContext.DatabaseNamePlaceholders.ToListAsync();

        return objectNamePlaceholders;
    }
}
