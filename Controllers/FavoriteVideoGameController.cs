using Microsoft.AspNetCore.Mvc;
using IT3045C_final.Models;

namespace IT3045C_final.Controllers;

[ApiController]
[Route("[controller]")]
public class FavoriteVideoGameController(ILogger<FavoriteVideoGameController> logger) : Controller
{
    private readonly ILogger<FavoriteVideoGameController> _logger = logger;

    public IActionResult Get()
    {
        var favoriteGames = new List<FavoriteVideoGame>
            {
                // ID 1 = Ben Stewart
                new() {
                    ID = 1,
                    Title = "Baldur's Gate 3",
                    Genre = "RPG",
                    Platform = "PC",
                    ReleaseYear = "2023"
                },
                // ID 2 = Patricia Echoles
                new() {
                    ID = 2,
                    Title = "God of War: Ragnarok",
                    Genre = "Action",
                    Platform = "PlayStation 4",
                    ReleaseYear = "2022"
                },
                // ID 3 = Madi Evanshine
                // TODO: update with correct info
                new() {
                    ID = 3,
                    Title = "UNKNOWN",
                    Genre = "UNKNOWN",
                    Platform = "UNKNOWN",
                    ReleaseYear = "UNKNOWN"
                },
                // ID 4 = Jacob Nolen
                // TODO: update with correct info
                new() {
                    ID = 4,
                    Title = "UNKNOWN",
                    Genre = "UNKNOWN",
                    Platform = "UNKNOWN",
                    ReleaseYear = "UNKNOWN"
                },
            };

        return View(favoriteGames);
    }
}