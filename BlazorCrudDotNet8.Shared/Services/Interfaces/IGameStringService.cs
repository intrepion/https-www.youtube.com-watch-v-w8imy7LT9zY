using BlazorCrudDotNet8.Shared.Entities;

namespace BlazorCrudDotNet8.Shared.Services.Interfaces;

public interface IGameStringService
{
    Task<GameString> AddAsync(GameString gameString);
    Task<bool> DeleteAsync(string id);
    Task<GameString> EditAsync(string id, GameString gameString);
    Task<List<GameString>> GetAllAsync();
    Task<GameString> GetByIdAsync(string id);
}
