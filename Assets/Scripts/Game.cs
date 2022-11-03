using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject block;

    private Camera _camera;
    private float _screenWidth;
    private float _screenHeight;

    private Model _model;
    private View _view;
    private Controller _controller;

    // Start is called before the first frame update
    void Awake()
    {
        ViewSettings.InitializePieceColors();
        PieceShapes.InitializePieceShapes();

        _camera = Camera.main;
        _screenHeight = 2 * _camera.orthographicSize;
        _screenWidth = _screenHeight * _camera.aspect;

        ViewSettings.CalculateBlockSideLength(_screenHeight);
        ViewSettings.CalculateMarginColumns(_screenWidth);
        ViewSettings.CalculateGameFieldOrigins();

        _model = new Model();
        _view = new View();
        _controller = new Controller();

        _view.InstantiateBoundaries(block);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
