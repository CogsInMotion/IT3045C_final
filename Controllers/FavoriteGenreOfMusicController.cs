using Microsoft.AspNetCore.Mvc;
using IT3045C_final.Models;

namespace IT3045C_final.Controllers;

[ApiController]
[Route("[controller]")]
public class FavoriteGenreOfMusicController : ControllerBase
{
    private static readonly List<FavoriteGenreOfMusic> favoriteGenres = new()
    {
        new FavoriteGenreOfMusic { ID = 1, Genre = "Rock", Artist = "Queen", Album = "A Night at the Opera", ReleaseYear = "1975" },
        new FavoriteGenreOfMusic { ID = 2, Genre = "Pop", Artist = "Michael Jackson", Album = "Thriller", ReleaseYear = "1982" },
        new FavoriteGenreOfMusic { ID = 3, Genre = "Hip Hop", Artist = "Tupac Shakur", Album = "All Eyez on Me", ReleaseYear = "1996" }
    };

    [HttpGet]
    public IEnumerable<FavoriteGenreOfMusic> Get()
    {
        return favoriteGenres;
    }

    [HttpGet("{id}")]
    public ActionResult<FavoriteGenreOfMusic> Get(int id)
    {
        var genre = favoriteGenres.FirstOrDefault(g => g.ID == id);
        if (genre == null)
        {
            return NotFound();
        }
        return genre;
    }
}