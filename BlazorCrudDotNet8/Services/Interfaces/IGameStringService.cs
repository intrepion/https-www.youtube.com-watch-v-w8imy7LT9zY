using BlazorCrudDotNet8.Entities;

namespace BlazorCrudDotNet8.Services.Interfaces;

public interface IGameStringService
{
    Task<GameString> AddAsync(GameString gameString);
    Task<List<GameString>> GetAllAsync();
}
