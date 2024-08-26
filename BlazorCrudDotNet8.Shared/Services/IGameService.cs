using BlazorCrudDotNet8.Shared.Entities;

namespace BlazorCrudDotNet8.Shared.Services;

public interface IGameService
{
    Task<Game> AddAsync(Game game);
    Task<bool> DeleteAsync(Guid id);
    Task<Game> EditAsync(Guid id, Game game);
    Task<List<Game>> GetAllAsync();
    Task<Game> GetByIdAsync(Guid id);
}
