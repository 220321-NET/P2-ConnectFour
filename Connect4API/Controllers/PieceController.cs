using Model;
using DL;
using Microsoft.AspNetCore.Mvc;

namespace Connect4API.Controllers;

[ApiController]
[Route("[controller]")]
public class PieceController : ControllerBase
{
    private readonly ILogger<PieceController> _logger;
    private readonly IDBRepo _dl;

    public PieceController(IDBRepo dl, ILogger<PieceController> logger)
    {
        _dl = dl;
        _logger = logger;
    }

    [HttpGet("GetPiece/{pieceID}")]
    public Piece Get(int pieceID)
    {
        return _dl.GetPiece(pieceID);
    }

    [HttpGet("GetAllPieces")]
    public List<Piece> GetAll(int boardID)
    {
        return _dl.GetAllPieces(boardID);
    }

    [HttpPost("AddPiece")]
    public void Post(Piece piece)
    {
        _dl.CreatePiece(piece);
    }
}