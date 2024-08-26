using BlazorCrudDotNet8.Entities;

namespace BlazorCrudDotNet8.Services.Interfaces;

public interface IGameIntService
{
    Task<List<GameInt>> GetAllAsync();
}
