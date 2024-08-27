using BlazorCrudDotNet8.Entities;

namespace BlazorCrudDotNet8.Services.Interfaces;

public interface IGameGuidService
{
    Task<GameGuid> AddAsync(GameGuid gameGuid);
    Task<List<GameGuid>> GetAllAsync();
}
