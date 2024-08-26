using BlazorCrudDotNet8.Shared.Entities;
using BlazorCrudDotNet8.Shared.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlazorCrudDotNet8.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GameController(IGameService gameService) : ControllerBase
{
    private readonly IGameService _gameService = gameService;

    [HttpPost]
    public async Task<ActionResult<Game>> Add(Game game)
    {
        var addedGame = await _gameService.AddAsync(game);

        return Ok(addedGame);
    }
}
