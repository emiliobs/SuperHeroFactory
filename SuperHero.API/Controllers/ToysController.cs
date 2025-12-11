using Microsoft.AspNetCore.Mvc;
using SuperHero.Application.DTOs;
using SuperHero.Application.Services;

namespace SuperHero.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ToysController : ControllerBase
{
    private readonly ISuperHeroService _service;

    public ToysController(ISuperHeroService service)
    {
        this._service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ToyDto>>> GetAll()
    {
        var heroes = await _service.GetAllAsync();
        return Ok(heroes);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<ToyDto>> GetById(int id)
    {
        var hero = await _service.GetByIdAsync(id);
        if (hero is null)
        {
            return NotFound();
        }

        return Ok(hero);
    }

    [HttpPost]
    public async Task<ActionResult<ToyDto>> Create([FromBody] CreateToyDto dto)
    {
        var created = await _service.CreateAsync(dto);
        return CreatedAtAction(nameof(GetById), new { id = created.id }, created);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, [FromBody] UpdateToyDto dto)
    {
        var updated = await _service.UpdateAsync(id, dto);
        if (!updated)
        {
            return NotFound();
        }

        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var deleted = await _service.DeleteAsync(id);
        if (!deleted)
        {
            return NotFound();
        }

        return NoContent();
    }
}