namespace Model;

public class Board
{
    public int BoardID { get; set; } = -1;
    public int Player1ID { get; set; } = -1;
    public int Player2ID { get; set; } = -1;
    public int WinID{get; set;} = -1;
    public List<Piece> BoardState { get; set; } = List<Piece>();
}