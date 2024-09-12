using BlazorCrudDotNet8.BusinessLogic.Entities.DataTransferObjects;

namespace BlazorCrudDotNet8.BusinessLogic.Services;

public interface IApplicationRoleAdminService
{
    Task<ApplicationRoleAdminDataTransferObject?> AddAsync(string userName, ApplicationRoleAdminDataTransferObject applicationRoleAdminDataTransferObject);
    Task<bool> DeleteAsync(string userName, Guid id);
    Task<ApplicationRoleAdminDataTransferObject?> EditAsync(string userName, Guid id, ApplicationRoleAdminDataTransferObject applicationRoleAdminDataTransferObject);
    Task<List<ApplicationRoleAdminDataTransferObject>?> GetAllAsync();
    Task<ApplicationRoleAdminDataTransferObject?> GetByIdAsync(Guid id);
}
