using BlazorCrudDotNet8.BusinessLogic.Entities;

namespace BlazorCrudDotNet8.BusinessLogic.Services;

public interface IGameService
{
    Task<List<Game>> GetAllGames();
    Task<Game> AddGame(Game game);
}
