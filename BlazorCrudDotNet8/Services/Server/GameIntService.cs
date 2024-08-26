using BlazorCrudDotNet8.Data;
using BlazorCrudDotNet8.Entities;
using BlazorCrudDotNet8.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudDotNet8.Services.Server;

public class GameIntService(ApplicationDbContext applicationDbContext) : IGameIntService
{
    private readonly ApplicationDbContext _applicationDbContext = applicationDbContext;

    public async Task<List<GameInt>> GetAllAsync()
    {
        var gameInts = await _applicationDbContext.GameInts.ToListAsync();

        return gameInts;
    }
}
