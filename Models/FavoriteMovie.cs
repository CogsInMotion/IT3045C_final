namespace IT3045C_final.Models;

public class FavoriteMovie
{
    public int ID { get; set; }
    public required string Title { get; set; }
    public required string Director { get; set; }
    public required string Genre { get; set; }
    public required string ReleaseYear { get; set; }
}