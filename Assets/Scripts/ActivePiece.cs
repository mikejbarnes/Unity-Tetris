using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePiece
{
    public GameSettings.Pieces Piece { get; private set; }
    public int Row { get; private set; }
    public int Column { get; private set; }

    public ActivePiece()
    {
        Piece = GameSettings.Pieces.IPiece;
        Row = ModelSettings.SpawnRow;
        Column = ModelSettings.SpawnColumn;
    }

    public void SetPiece(GameSettings.Pieces piece)
    {
        Piece = piece;
        Row = ModelSettings.SpawnRow;
        Column = ModelSettings.SpawnColumn;
    }
}
