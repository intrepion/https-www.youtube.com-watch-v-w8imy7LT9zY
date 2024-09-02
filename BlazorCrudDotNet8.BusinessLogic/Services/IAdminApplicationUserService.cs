using BlazorCrudDotNet8.BusinessLogic.Entities;

namespace BlazorCrudDotNet8.BusinessLogic.Services;

public interface IAdminApplicationUserService
{
    Task<ApplicationUser?> AddAsync(string userName, ApplicationUser applicationUser);
    Task<bool> DeleteAsync(string userName, string id);
    Task<ApplicationUser?> EditAsync(string userName, string id, ApplicationUser applicationUser);
    Task<List<ApplicationUser>?> GetAllAsync();
    Task<ApplicationUser?> GetByIdAsync(string id);
}
