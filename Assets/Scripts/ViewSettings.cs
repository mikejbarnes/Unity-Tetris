using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ViewSettings
{
    public static float BlockSideLength = 1.0f;
    public static int BoundaryThickness = 1;
    public static int ScreenRows;
    public static int ScreenColumns;
    public static float CenteringAdjustment;
    public static int ScreenMarginColumns = 1;
    public static int ScreenMarginRows = 2;
    public static int HoldRows = 6;
    public static int HoldColumns = 6;
    public static int NextPieceRows = 18;
    public static int NextPieceColumns = 6;
    public static int InterBoundaryMargin = 2;

    public static int[] GameFieldOrigin;
    public static int[] HoldOrigin;
    public static int[] NextPieceOrigin;

    public static Dictionary<GameSettings.Pieces, Color> Colors = new Dictionary<GameSettings.Pieces, Color>();

    public static float[] ConvertGridToWorldSpace(int[] position)
    {
        //Subtract the 0.5f to account for the reference point being in the upper left corner of the block
        float worldSpaceX = BlockSideLength * (position[0] - ScreenColumns/2 - 0.5f) + CenteringAdjustment;
        float worldSpaceY = BlockSideLength * (position[1] - ScreenRows/2 - 0.5f);

        return new float[] { worldSpaceX, worldSpaceY };
    }

    public static void InitializePieceColors()
    {
        Colors.Add(GameSettings.Pieces.IPiece, new Color(0.0f, 1.0f, 1.0f));
        Colors.Add(GameSettings.Pieces.OPiece, new Color(1.0f, 0.0f, 1.0f));
        Colors.Add(GameSettings.Pieces.TPiece, new Color(1.0f, 1.0f, 0.0f));
        Colors.Add(GameSettings.Pieces.JPiece, new Color(0.0f, 1.0f, 0.0f));
        Colors.Add(GameSettings.Pieces.LPiece, new Color(1.0f, 0.5f, 0.0f));
        Colors.Add(GameSettings.Pieces.SPiece, new Color(0.0f, 0.0f, 1.0f));
        Colors.Add(GameSettings.Pieces.ZPiece, new Color(1.0f, 0.0f, 0.0f));
        Colors.Add(GameSettings.Pieces.Boundary, new Color(0.5f, 0.5f, 0.5f));
    }

    public static void CalculateBlockSideLength(float screenHeight)
    {
        ScreenRows = 2 * ScreenMarginRows + ModelSettings.GameFieldRows;
        BlockSideLength = screenHeight / ScreenRows;

        Debug.Log(ScreenRows);
        Debug.Log(BlockSideLength);
    }

    public static void CalculateMarginColumns(float screenWidth)
    {
        float totalColumns = screenWidth / BlockSideLength;
        ScreenColumns = Convert.ToInt32(Mathf.Floor(totalColumns));
        ScreenMarginColumns = (ScreenColumns - ModelSettings.GameFieldColumns) / 2;
        CenteringAdjustment = (totalColumns - ScreenColumns)/2;

        Debug.Log(ScreenColumns);
        Debug.Log(totalColumns);
        Debug.Log(CenteringAdjustment);
    }

    public static void CalculateGameFieldOrigins()
    {
        GameFieldOrigin = new int[] { ScreenMarginRows + ModelSettings.GameFieldRows, ScreenMarginColumns };
        HoldOrigin = new int[] { GameFieldOrigin[0], GameFieldOrigin[1] - (2 * BoundaryThickness) - InterBoundaryMargin - HoldColumns };
        NextPieceOrigin = new int[] { GameFieldOrigin[0], GameFieldOrigin[1] + ModelSettings.GameFieldColumns + (2 * BoundaryThickness) + InterBoundaryMargin };
    }
}
