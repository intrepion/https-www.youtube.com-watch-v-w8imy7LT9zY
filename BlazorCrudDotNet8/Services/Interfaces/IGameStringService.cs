using BlazorCrudDotNet8.Entities;

namespace BlazorCrudDotNet8.Services.Interfaces;

public interface IGameStringService
{
    Task<List<GameString>> GetAllAsync();
}
