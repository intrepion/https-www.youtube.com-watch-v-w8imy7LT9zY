using BlazorCrudDotNet8.Data;
using BlazorCrudDotNet8.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudDotNet8.Services;

public class GameService(ApplicationDbContext applicationDbContext) : IGameService
{
    private readonly ApplicationDbContext _applicationDbContext = applicationDbContext;

    public async Task<Game> AddGame(Game game)
    {
        _applicationDbContext.Games.Add(game);
        await _applicationDbContext.SaveChangesAsync();

        return game;
    }

    public async Task<List<Game>> GetAllGames()
    {
        await Task.Delay(1000);

        var games = await _applicationDbContext.Games.ToListAsync();

        return games;
    }
}
