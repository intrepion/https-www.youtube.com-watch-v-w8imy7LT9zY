using BlazorCrudDotNet8.BusinessLogic.Data;
using BlazorCrudDotNet8.BusinessLogic.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudDotNet8.BusinessLogic.Services;

public class GameService(ApplicationDbContext applicationDbContext) : IGameService
{
    private readonly ApplicationDbContext _applicationDbContext = applicationDbContext;

    public async Task<Game> AddGame(Game game)
    {
        _applicationDbContext.Games.Add(game);
        await _applicationDbContext.SaveChangesAsync();

        return game;
    }

    public async Task<bool> DeleteGame(int id)
    {
        var dbGame = await _applicationDbContext.Games.FindAsync(id);

        if (dbGame != null)
        {
            _applicationDbContext.Remove(dbGame);
            await _applicationDbContext.SaveChangesAsync();

            return true;
        }

        return false;
    }

    public async Task<Game> EditGame(int id, Game game)
    {
        var dbGame = await _applicationDbContext.Games.FindAsync(id);

        if (dbGame != null)
        {
            dbGame.Name = game.Name;
            await _applicationDbContext.SaveChangesAsync();

            return dbGame;
        }

        throw new Exception("Game not found.");
    }

    public async Task<List<Game>> GetAllGames()
    {
        await Task.Delay(1000);

        var games = await _applicationDbContext.Games.ToListAsync();

        return games;
    }

    public async Task<Game> GetGameById(int id)
    {
        return await _applicationDbContext.Games.FindAsync(id);
    }
}
