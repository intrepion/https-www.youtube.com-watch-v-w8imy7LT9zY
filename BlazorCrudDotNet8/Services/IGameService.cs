using BlazorCrudDotNet8.Entities;

namespace BlazorCrudDotNet8.Services;

public interface IGameService
{
    Task<List<Game>> GetAllGames();
    Task<Game> AddGame(Game game);
}
