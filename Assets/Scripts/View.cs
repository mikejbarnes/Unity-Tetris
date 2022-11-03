using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View
{
    private GameObject[] _gameBoardBoundary;
    private int _gameBoardBoundaryPerimeter;
    private GameObject[] _holdBoundary;
    private int _holdBoundaryPerimeter;
    private GameObject[] _nextPieceBoundary;
    private int _nextPiecePerimeter;

    public View()
    {
        _gameBoardBoundaryPerimeter = 2 * (ModelSettings.GameFieldRows + ModelSettings.GameFieldColumns) + 4;
        _gameBoardBoundary = new GameObject[_gameBoardBoundaryPerimeter];
        _holdBoundaryPerimeter = 2 * (ViewSettings.HoldRows + ViewSettings.HoldColumns) + 4;
        _holdBoundary = new GameObject[_holdBoundaryPerimeter];
        _nextPiecePerimeter = 2 * (ViewSettings.NextPieceRows + ViewSettings.NextPieceColumns) + 4;
        _nextPieceBoundary = new GameObject[_nextPiecePerimeter];
    }

    // Update is called once per frame
    void OnUpdate()
    {
        
    }

    public void InstantiateBoundaries(GameObject block)
    {
        BuildBoundary(block, _gameBoardBoundaryPerimeter, ModelSettings.GameFieldColumns, ModelSettings.GameFieldRows, ViewSettings.GameFieldOrigin, ref _gameBoardBoundary);
        BuildBoundary(block, _holdBoundaryPerimeter, ViewSettings.HoldColumns, ViewSettings.HoldRows, ViewSettings.HoldOrigin, ref _holdBoundary);
        BuildBoundary(block, _nextPiecePerimeter, ViewSettings.NextPieceColumns, ViewSettings.NextPieceRows, ViewSettings.NextPieceOrigin, ref _nextPieceBoundary);
    }

    private void BuildBoundary(GameObject block, int perimeter, int width, int height, int[] origin, ref GameObject[] container)
    {
        int currentBoundaryPositionX = origin[1] - 2;
        int currentBoundaryPositionY = origin[0] + 1;

        for (int i = 0; i < perimeter; i++)
        {
            if (i < width + 2)
            {
                currentBoundaryPositionX++;
            }
            else if (i < width + 2 + height + 1)
            {
                currentBoundaryPositionY--;
            }
            else if (i < 2 * width + 3 + height + 1)
            {
                currentBoundaryPositionX--;
            }
            else
            {
                currentBoundaryPositionY++;
            }

            float[] worldSpacePosition = ViewSettings.ConvertGridToWorldSpace(new int[] { currentBoundaryPositionX, currentBoundaryPositionY });
            Vector3 boundaryPosition = new Vector3(worldSpacePosition[0], worldSpacePosition[1], 0);
            container[i] = Object.Instantiate(block, boundaryPosition, Quaternion.identity);
            container[i].GetComponent<BlockBehaviors>().SetColor(ViewSettings.Colors[GameSettings.Pieces.Boundary]);
        }
    }
}
