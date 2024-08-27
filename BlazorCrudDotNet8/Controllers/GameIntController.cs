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

    [HttpDelete("{id}")]
    public async Task<ActionResult<GameInt>> Delete(int id)
    {
        var result = await _gameIntService.DeleteAsync(id);

        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<GameInt>> Edit(int id, GameInt gameInt)
    {
        var updatedGame = await _gameIntService.EditAsync(id, gameInt);

        return Ok(updatedGame);
    }

    [HttpGet]
    public async Task<ActionResult<GameInt>> GetAll()
    {
        var games = await _gameIntService.GetAllAsync();

        return Ok(games);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<GameInt>> GetById(int id)
    {
        var game = await _gameIntService.GetByIdAsync(id);

        return Ok(game);
    }
}
