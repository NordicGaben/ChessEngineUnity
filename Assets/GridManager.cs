using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// Based on Tarodev video https://www.youtube.com/watch?v=kkAjpQAM-jE&ab_channel=Tarodev

public class GridManager : MonoBehaviour
{
    [SerializeField] 
    private int _width = 8, _height = 8;

    [SerializeField]
    private Tile _tilePrefab;

    [SerializeField]
    private Transform _cam;


    void GenerateGrid()
    {
        GenerateGrid(8, 8);
    }

    void GenerateGrid(int width, int height)
    {
        _width = width;
        _height = height;
        for (int rank = 0; rank < _height; rank++)
        {
            for (int file = 0; file < _width; file++)
            {
                Tile spawnedTile = Instantiate(_tilePrefab, new Vector2(rank, file), Quaternion.identity, transform);
                spawnedTile.name = $"Tile {(File)file}{rank}";

                bool IsWhite = (rank + file) % 2 == 1; // when one is odd and one is even, this is if we count a1 as (0,0).
                spawnedTile.Init(IsWhite); 
            }
        }

        Camera.main.transform.position = new Vector3(_width/2f - 0.5f, _height/2f - 0.5f, -10); // 0.5 is half a tile width.
    }

    // Start is called before the first frame update
    void Start()
    {
        GenerateGrid(8, 8);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public enum File { a, b, c, d, e, f, g, h }