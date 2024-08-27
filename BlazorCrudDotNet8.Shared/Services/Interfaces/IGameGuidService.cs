using BlazorCrudDotNet8.Shared.Entities;

namespace BlazorCrudDotNet8.Shared.Services.Interfaces;

public interface IGameGuidService
{
    Task<GameGuid> AddAsync(GameGuid gameGuid);
    Task<bool> DeleteAsync(Guid id);
    Task<GameGuid> EditAsync(Guid id, GameGuid gameGuid);
    Task<List<GameGuid>> GetAllAsync();
    Task<GameGuid> GetByIdAsync(Guid id);
}
