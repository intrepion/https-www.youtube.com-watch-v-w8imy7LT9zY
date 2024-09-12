using BlazorCrudDotNet8.BusinessLogic.Entities.DataTransferObjects;

namespace BlazorCrudDotNet8.BusinessLogic.Services;

public interface IApplicationUserAdminService
{
    Task<ApplicationUserAdminDataTransferObject?> AddAsync(string userName, ApplicationUserAdminDataTransferObject applicationUserAdminDataTransferObject);
    Task<bool> DeleteAsync(string userName, Guid id);
    Task<ApplicationUserAdminDataTransferObject?> EditAsync(string userName, Guid id, ApplicationUserAdminDataTransferObject applicationUserAdminDataTransferObject);
    Task<List<ApplicationUserAdminDataTransferObject>?> GetAllAsync();
    Task<ApplicationUserAdminDataTransferObject?> GetByIdAsync(Guid id);
}
