using BlazorCrudDotNet8.Data;
using BlazorCrudDotNet8.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudDotNet8.Services;

public class GameService(ApplicationDbContext applicationDbContext) : IGameService
{
    private readonly ApplicationDbContext _applicationDbContext = applicationDbContext;

    public async Task<List<Game>> GetAllGames()
    {
        var games = await _applicationDbContext.Games.ToListAsync();

        return games;
    }
}
