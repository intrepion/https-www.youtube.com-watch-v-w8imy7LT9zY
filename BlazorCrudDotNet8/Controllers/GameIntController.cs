using BlazorCrudDotNet8.Shared.Entities;
using BlazorCrudDotNet8.Shared.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlazorCrudDotNet8.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GameIntController(IGameIntService gameIntService) : ControllerBase
{
    private readonly IGameIntService _gameIntService = gameIntService;

    [HttpPost]
    public async Task<ActionResult<GameInt>> Add(GameInt gameInt)
    {
        var addedGame = await _gameIntService.AddAsync(gameInt);

        return Ok(addedGame);
    }
}
