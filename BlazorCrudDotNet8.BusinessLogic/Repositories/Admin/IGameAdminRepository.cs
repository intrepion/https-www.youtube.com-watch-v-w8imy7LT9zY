using BlazorCrudDotNet8.BusinessLogic.Entities.Dtos.Admin;

namespace BlazorCrudDotNet8.BusinessLogic.Repositories.Admin;

public interface IGameAdminRepository
{
    Task<GameAdminDto?> AddAsync(GameAdminDto game);
    Task<bool> DeleteAsync(string userName, Guid id);
    Task<GameAdminDto?> EditAsync(GameAdminDto game);
    Task<List<GameAdminDto>?> GetAllAsync(string userName);
    Task<GameAdminDto?> GetByIdAsync(string userName, Guid id);
}
