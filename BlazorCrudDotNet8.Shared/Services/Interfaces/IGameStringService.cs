using BlazorCrudDotNet8.Shared.Entities;

namespace BlazorCrudDotNet8.Shared.Services.Interfaces;

public interface IGameStringService
{
    Task<GameString> AddAsync(GameString gameString);
    Task<List<GameString>> GetAllAsync();
}
