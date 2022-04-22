using Model;
using Microsoft.EntityFrameworkCore;

namespace DL;

public class DBContext
{
    public DBContext() : base() { }
    public DBContext(DbContextOptions options) : base() { }
    public DbSet<Board>? Boards { get; set; }
    public DbSet<Lobby>? Lobbys { get; set; }
    public DbSet<Piece>? Pieces { get; set; }
    public DbSet<Player>? Players { get; set; }
    public DbSet<Ranking>? Rankings { get; set; }

}

// dotnet ef migrations add initial -c DBContext --startup-project ../Connect4API
// new name everytime 'initial'

// dotnet ef database update --startup-project ../Connect4API