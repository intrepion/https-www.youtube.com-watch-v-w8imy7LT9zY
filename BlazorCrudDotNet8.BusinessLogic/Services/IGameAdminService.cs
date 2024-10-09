using ApplicationNamePlaceholder.BusinessLogic.Entities;
using ApplicationNamePlaceholder.BusinessLogic.Entities.Dtos;

namespace ApplicationNamePlaceholder.BusinessLogic.Services;

public interface IGameAdminService
{
    Task<GameAdminDto?> AddAsync(GameAdminDto game);
    Task<bool> DeleteAsync(string userName, Guid id);
    Task<GameAdminDto?> EditAsync(GameAdminDto game);
    Task<List<Game>?> GetAllAsync(string userName);
    Task<GameAdminDto?> GetByIdAsync(string userName, Guid id);
}
