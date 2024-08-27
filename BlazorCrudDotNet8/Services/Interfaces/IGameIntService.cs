using BlazorCrudDotNet8.Entities;

namespace BlazorCrudDotNet8.Services.Interfaces;

public interface IGameIntService
{
    Task<GameInt> AddAsync(GameInt gameInt);
    Task<List<GameInt>> GetAllAsync();
}
