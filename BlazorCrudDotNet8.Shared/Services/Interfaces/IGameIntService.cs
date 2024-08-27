using BlazorCrudDotNet8.Shared.Entities;

namespace BlazorCrudDotNet8.Shared.Services.Interfaces;

public interface IGameIntService
{
    Task<GameInt> AddAsync(GameInt gameInt);
    Task<List<GameInt>> GetAllAsync();
}
