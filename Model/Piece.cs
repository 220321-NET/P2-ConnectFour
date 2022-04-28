using System.ComponentModel.DataAnnotations;
namespace Model;
public class Piece
{
    [Key]
    public int PieceID { get; set; }
    public int BoardID { get; set; }
    public int PlayerID { get; set; }
    public int xCoordinate { get; set; }
    public int yCoordinate { get; set; }
}