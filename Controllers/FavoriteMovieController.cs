using Microsoft.AspNetCore.Mvc;
using IT3045C_final.Models;

namespace IT3045C_final.Controllers;

[ApiController]
[Route("[controller]")]
public class FavoriteMovieController : ControllerBase
{
    private static readonly List<FavoriteMovie> favoriteMovies = new()
    {
        new FavoriteMovie { ID = 1, Title = "The Shawshank Redemption", Director = "Frank Darabont", ReleaseYear = "1994", Genre = "Drama" },
        new FavoriteMovie { ID = 2, Title = "The Godfather", Director = "Francis Ford Coppola", ReleaseYear = "1972", Genre = "Crime" },
        new FavoriteMovie { ID = 3, Title = "Inception", Director = "Christopher Nolan", ReleaseYear = "2010", Genre = "Sci-Fi" }
    };

    [HttpGet]
    public IEnumerable<FavoriteMovie> Get()
    {
        return favoriteMovies;
    }

    [HttpGet("{id}")]
    public ActionResult<FavoriteMovie> Get(int id)
    {
        var movie = favoriteMovies.FirstOrDefault(m => m.ID == id);
        if (movie == null)
        {
            return NotFound();
        }
        return movie;
    }

    [HttpPost]
    public ActionResult<FavoriteMovie> Post(FavoriteMovie movie)
    {
        movie.ID = favoriteMovies.Max(x => x.ID) + 1;
        favoriteMovies.Add(movie);
        return Ok(movie);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, FavoriteMovie updated)
    {
        var existing = favoriteMovies.FirstOrDefault(x => x.ID == id);
        if (existing == null) return NotFound();

        existing.Title = updated.Title;
        existing.Director = updated.Director;
        existing.ReleaseYear = updated.ReleaseYear;
        existing.Genre = updated.Genre;

        return Ok(existing);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var movie = favoriteMovies.FirstOrDefault(x => x.ID == id);
        if (movie == null) return NotFound();

        favoriteMovies.Remove(movie);
        return Ok();
    }
}
