using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model
{
    public GameSettings.Pieces[,] GameField { get; private set; }
    public GameSettings.Pieces HeldPiece { get; private set; }
    public GameSettings.Pieces[] NextPieces { get; private set; }

    private ActivePiece _activePiece;

    public Model()
    {
        _activePiece = new ActivePiece();
    }

    // Update is called once per frame
    void OnUpdate()
    {
        
    }
}
