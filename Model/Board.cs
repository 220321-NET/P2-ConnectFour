using System.ComponentModel.DataAnnotations;
namespace Model;

public class Board
{
    [Key]
    public int BoardID { get; set; }
    public int PlayerID { get; set; }
    public int LobbyID { get; set; }
}