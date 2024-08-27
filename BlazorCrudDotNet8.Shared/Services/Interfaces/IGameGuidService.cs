using BlazorCrudDotNet8.Shared.Entities;

namespace BlazorCrudDotNet8.Shared.Services.Interfaces;

public interface IGameGuidService
{
    Task<GameGuid> AddAsync(GameGuid gameGuid);
    Task<List<GameGuid>> GetAllAsync();
}
