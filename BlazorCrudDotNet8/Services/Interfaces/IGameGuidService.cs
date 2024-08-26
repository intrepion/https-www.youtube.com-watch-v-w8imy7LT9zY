using BlazorCrudDotNet8.Entities;

namespace BlazorCrudDotNet8.Services.Interfaces;

public interface IGameGuidService
{
    Task<List<GameGuid>> GetAllAsync();
}
