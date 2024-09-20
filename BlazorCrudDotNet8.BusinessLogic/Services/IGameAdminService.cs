using BlazorCrudDotNet8.BusinessLogic.Entities.DataTransferObjects;

namespace BlazorCrudDotNet8.BusinessLogic.Services;

public interface IGameAdminService
{
    Task<GameAdminDataTransferObject?> AddAsync(string userName, GameAdminDataTransferObject game);
    Task<bool> DeleteAsync(string userName, Guid id);
    Task<GameAdminDataTransferObject?> EditAsync(string userName, Guid id, GameAdminDataTransferObject game);
    Task<List<GameAdminDataTransferObject>?> GetAllAsync();
    Task<GameAdminDataTransferObject?> GetByIdAsync(Guid id);
}
