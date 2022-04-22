namespace Model;

public class Player
{
    public int PlayerID { get; set; } = -1;
    public string Username { get; set; } = "";
    public string Password{get; set;} = "";
    public int Wins { get; set; } = 0;
    public int Losses { get; set; } = 0;
    public int Ties { get; set; } = 0;

}