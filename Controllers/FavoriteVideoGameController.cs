using Microsoft.AspNetCore.Mvc;
using IT3045C_final.Models;

namespace IT3045C_final.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FavoriteVideoGameController(ILogger<FavoriteVideoGameController> logger) : Controller
{
    private readonly ILogger<FavoriteVideoGameController> _logger = logger;

    private static readonly List<FavoriteVideoGame> favoriteGames = new()
    {
        new() {
            ID = 1,
            Title = "Baldur's Gate 3",
            Genre = "RPG",
            Platform = "PC",
            ReleaseYear = "2023"
        },
        new() {
            ID = 2,
            Title = "God of War: Ragnarok",
            Genre = "Action",
            Platform = "PlayStation 4",
            ReleaseYear = "2022"
        },
        new() {
            ID = 3,
            Title = "Dead by Daylight",
            Genre = "Horror",
            Platform = "PC",
            ReleaseYear = "2016"
        },
        new() {
            ID = 4,
            Title = "Hylics 2",
            Genre = "RPG",
            Platform = "PC",
            ReleaseYear = "2020"
        },
    };

    public IActionResult Get()
    {
        return View(favoriteGames);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var game = favoriteGames.FirstOrDefault(x => x.ID == id);
        if (game == null) return NotFound();
        return Ok(game);
    }

    [HttpPost]
    public IActionResult Post([FromBody] FavoriteVideoGame newGame)
    {
        newGame.ID = favoriteGames.Max(x => x.ID) + 1;
        favoriteGames.Add(newGame);
        return Ok(newGame);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] FavoriteVideoGame updated)
    {
        var existing = favoriteGames.FirstOrDefault(x => x.ID == id);
        if (existing == null) return NotFound();

        existing.Title = updated.Title;
        existing.Genre = updated.Genre;
        existing.Platform = updated.Platform;
        existing.ReleaseYear = updated.ReleaseYear;

        return Ok(existing);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var game = favoriteGames.FirstOrDefault(x => x.ID == id);
        if (game == null) return NotFound();

        favoriteGames.Remove(game);
        return Ok();
    }
}
