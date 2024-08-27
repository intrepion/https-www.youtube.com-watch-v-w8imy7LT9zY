using BlazorCrudDotNet8.Shared.Entities;

namespace BlazorCrudDotNet8.Shared.Services.Interfaces;

public interface IGameIntService
{
    Task<GameInt> AddAsync(GameInt gameInt);
    Task<bool> DeleteAsync(int id);
    Task<GameInt> EditAsync(int id, GameInt gameInt);
    Task<List<GameInt>> GetAllAsync();
    Task<GameInt> GetByIdAsync(int id);
}
