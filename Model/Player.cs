using System.ComponentModel.DataAnnotations;
namespace Model;

public class Player
{
    //[Key]
    public int PlayerID { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
    public int Wins { get; set; } = 0;
    public int Losses { get; set; } = 0;
    public int Ties { get; set; } = 0;

}