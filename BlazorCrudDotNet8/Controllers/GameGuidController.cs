using BlazorCrudDotNet8.Shared.Entities;
using BlazorCrudDotNet8.Shared.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlazorCrudDotNet8.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GameGuidController(IGameGuidService gameGuidService) : ControllerBase
{
    private readonly IGameGuidService _gameGuidService = gameGuidService;

    [HttpPost]
    public async Task<ActionResult<GameGuid>> Add(GameGuid gameGuid)
    {
        var addedGame = await _gameGuidService.AddAsync(gameGuid);

        return Ok(addedGame);
    }
}
