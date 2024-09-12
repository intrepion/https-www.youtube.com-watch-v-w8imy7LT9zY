using ApplicationNamePlaceholder.BusinessLogic.Entities;

namespace ApplicationNamePlaceholder.BusinessLogic.Services;

public interface IGameAdminService
{
    Task<Game?> AddAsync(string userName, Game game);
    Task<bool> DeleteAsync(string userName, Guid id);
    Task<Game?> EditAsync(string userName, Guid id, Game game);
    Task<List<Game>?> GetAllAsync();
    Task<Game?> GetByIdAsync(Guid id);
}
