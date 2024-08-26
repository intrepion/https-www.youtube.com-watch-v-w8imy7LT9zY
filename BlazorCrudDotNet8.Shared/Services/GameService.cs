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

    public async Task<List<Game>> GetAllAsync()
    {
        await Task.Delay(1000);

        var games = await _applicationDbContext.Games.ToListAsync();

        return games;
    }
}
