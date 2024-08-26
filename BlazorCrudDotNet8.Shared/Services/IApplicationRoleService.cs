using BlazorCrudDotNet8.Shared.Entities;

namespace BlazorCrudDotNet8.Shared.Services;

public interface IApplicationRoleService
{
    Task<List<ApplicationRole>> GetAllAsync();
}
