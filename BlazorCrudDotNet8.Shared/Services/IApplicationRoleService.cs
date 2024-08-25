using BlazorCrudDotNet8.Shared.Entities;

namespace BlazorCrudDotNet8.Shared.Services;

public interface IClassNamePlaceholderService
{
    Task<List<ClassNamePlaceholder>> GetAllAsync();
}
