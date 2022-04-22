using Model;
using Microsoft.EntityFrameworkCore;

namespace DL;

public class C4DBContext : DbContext
{
    public C4DBContext() : base() { }
    public C4DBContext(DbContextOptions options) : base(options) { }
    public DbSet<Board>? Boards { get; set; }
    public DbSet<Lobby>? Lobbys { get; set; }
    public DbSet<Piece>? Pieces { get; set; }
    public DbSet<Player>? Players { get; set; }
    public DbSet<Ranking>? Rankings { get; set; }

}

// dotnet ef migrations add initial -c C4DBContext --startup-project ../Connect4API
// new name everytime 'initial'

// dotnet ef database update --startup-project ../Connect4API