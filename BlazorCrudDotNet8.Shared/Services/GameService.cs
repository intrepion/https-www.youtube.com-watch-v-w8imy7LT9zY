using BlazorCrudDotNet8.Shared.Data;
using BlazorCrudDotNet8.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudDotNet8.Shared.Services;

public class GameService(ApplicationDbContext applicationDbContext) : IGameService
{
    private readonly ApplicationDbContext _applicationDbContext = applicationDbContext;

    public async Task<Game> AddAsync(Game game)
    {
        _applicationDbContext.Games.Add(game);
        await _applicationDbContext.SaveChangesAsync();

        return game;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var dbGame = await _applicationDbContext.Games.FindAsync(id);

        if (dbGame == null)
        {
            return false;
        }

        _applicationDbContext.Remove(dbGame);
        await _applicationDbContext.SaveChangesAsync();

        return true;
    }

    public async Task<Game> EditAsync(Guid id, Game game)
    {
        var dbGame = await _applicationDbContext.Games.FindAsync(id);

        if (dbGame == null)
        {
            throw new Exception("Game not found.");
        }

        dbGame.Name = game.Name;
        await _applicationDbContext.SaveChangesAsync();

        return dbGame;
    }

    public async Task<List<Game>> GetAllAsync()
    {
        await Task.Delay(1000);

        var games = await _applicationDbContext.Games.ToListAsync();

        return games;
    }

    public async Task<Game> GetByIdAsync(Guid id)
    {
        return await _applicationDbContext.Games.FindAsync(id);
    }
}
