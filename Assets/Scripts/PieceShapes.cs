using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PieceShapes
{
    public static Dictionary<GameSettings.Pieces, int[,]> Pieces = new Dictionary<GameSettings.Pieces, int[,]>();
    public static int[] SpawnLocation = new int[] { 1, 1 };

    public static void InitializePieceShapes()
    {
        Pieces.Add(GameSettings.Pieces.IPiece, IPiece);
        Pieces.Add(GameSettings.Pieces.OPiece, OPiece);
        Pieces.Add(GameSettings.Pieces.TPiece, TPiece);
        Pieces.Add(GameSettings.Pieces.JPiece, JPiece);
        Pieces.Add(GameSettings.Pieces.LPiece, LPiece);
        Pieces.Add(GameSettings.Pieces.SPiece, SPiece);
        Pieces.Add(GameSettings.Pieces.ZPiece, ZPiece);
    }

    public static int[,] IPiece = new int[,] 
    {
        { 0, 0, 0, 0 },
        { 1, 1, 1, 1 },
        { 0, 0, 0, 0 },
        { 0, 0, 0, 0 } 
    };

    public static int[,] OPiece = new int[,]
    {
        { 0, 1, 1, 0 },
        { 0, 1, 1, 0 },
        { 0, 0, 0, 0 }
    };

    public static int[,] TPiece = new int[,]
    {
        { 0, 1, 0 },
        { 1, 1, 1 },
        { 0, 0, 0 }
    };

    public static int[,] JPiece = new int[,]
    {
        { 1, 0, 0 },
        { 1, 1, 1 },
        { 0, 0, 0 }
    };

    public static int[,] LPiece = new int[,]
    {
        { 0, 0, 1 },
        { 1, 1, 1 },
        { 0, 0, 0 }
    };

    public static int[,] SPiece = new int[,]
    {
        { 0, 1, 1 },
        { 1, 1, 0 },
        { 0, 0, 0 }
    };

    public static int[,] ZPiece = new int[,]
    {
        { 1, 1, 0 },
        { 0, 1, 1 },
        { 0, 0, 0 }
    };
}
