using System.ComponentModel.DataAnnotations;
namespace Model;

public class Lobby
{
    [Key]
    public int LobbyID {get;set;}
    public int Player1ID { get; set; }
    public int Player2ID { get; set; }

}