using BlazorCrudDotNet8.Data;
using BlazorCrudDotNet8.Entities;
using BlazorCrudDotNet8.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudDotNet8.Services.Server;

public class GameGuidService(ApplicationDbContext applicationDbContext) : IGameGuidService
{
    private readonly ApplicationDbContext _applicationDbContext = applicationDbContext;

    public async Task<List<GameGuid>> GetAllAsync()
    {
        var gameGuids = await _applicationDbContext.GameGuids.ToListAsync();

        return gameGuids;
    }
}
