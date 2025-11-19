namespace IT3045C_final.Models;

public class FavoriteVideoGame
{
    public int ID { get; set; }
    public required string Title { get; set; }
    public required string Genre { get; set; }
    public required string Platform { get; set; }
    public required string ReleaseYear { get; set; }
}