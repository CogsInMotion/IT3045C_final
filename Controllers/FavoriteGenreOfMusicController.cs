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

    [HttpPost]
    public IActionResult Post(FavoriteGenreOfMusic genre)
    {
        genre.ID = favoriteGenres.Max(x => x.ID) + 1;
        favoriteGenres.Add(genre);
        return Ok(genre);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, FavoriteGenreOfMusic updated)
    {
        var existing = favoriteGenres.FirstOrDefault(x => x.ID == id);
        if (existing == null) return NotFound();

        existing.Genre = updated.Genre;
        existing.Artist = updated.Artist;
        existing.Album = updated.Album;
        existing.ReleaseYear = updated.ReleaseYear;

        return Ok(existing);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var genre = favoriteGenres.FirstOrDefault(x => x.ID == id);
        if (genre == null) return NotFound();

        favoriteGenres.Remove(genre);
        return Ok();
    }
}
