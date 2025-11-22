namespace IT3045C_final.Models;

public class FavoriteGenreOfMusic
{
    public int ID { get; set; }
    public required string Genre { get; set; }
    public required string Artist { get; set; }
    public required string Album { get; set; }
    public required string ReleaseYear { get; set; }
}