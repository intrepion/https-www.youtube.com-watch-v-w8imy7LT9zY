using BlazorCrudDotNet8.Shared.Entities;
using BlazorCrudDotNet8.Shared.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlazorCrudDotNet8.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GameStringController(IGameStringService gameStringService) : ControllerBase
{
    private readonly IGameStringService _gameStringService = gameStringService;

    [HttpPost]
    public async Task<ActionResult<GameString>> Add(GameString gameString)
    {
        var addedGame = await _gameStringService.AddAsync(gameString);

        return Ok(addedGame);
    }
}
