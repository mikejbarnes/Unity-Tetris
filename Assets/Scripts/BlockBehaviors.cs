using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehaviors : MonoBehaviour
{
    private Transform _transform;
    private Renderer _renderer;

    // Awake is called before the first frame update
    void Awake()
    {
        _transform = this.GetComponent<Transform>();
        _renderer = this.GetComponent<Renderer>();

        _transform.localScale = new Vector3(ViewSettings.BlockSideLength, ViewSettings.BlockSideLength, ViewSettings.BlockSideLength);
    }

    public void SetColor(Color color)
    {
        _renderer.material.color = color;
    }
}
