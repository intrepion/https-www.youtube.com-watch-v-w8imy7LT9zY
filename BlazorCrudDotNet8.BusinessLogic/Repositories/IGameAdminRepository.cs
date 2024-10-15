using BlazorCrudDotNet8.BusinessLogic.Entities;
using BlazorCrudDotNet8.BusinessLogic.Entities.Dtos;

namespace BlazorCrudDotNet8.BusinessLogic.Repositories;

public interface IGameAdminRepository
{
    Task<GameAdminDto?> AddAsync(GameAdminDto game);
    Task<bool> DeleteAsync(string userName, Guid id);
    Task<GameAdminDto?> EditAsync(GameAdminDto game);
    Task<List<Game>?> GetAllAsync(string userName);
    Task<GameAdminDto?> GetByIdAsync(string userName, Guid id);
}
