using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Based on Tarodev video https://www.youtube.com/watch?v=kkAjpQAM-jE&ab_channel=Tarodev

public class Tile : MonoBehaviour
{
    [SerializeField] private Color _whiteColor, _blackColor;
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private GameObject _highlight;

    public void Init(bool IsWhite)
    {
        _renderer.color = IsWhite ? _whiteColor : _blackColor;
    }

    private void OnMouseEnter()
    {
        //The hightlight square child of the tile is set to false at instanciation.
        // This sets it to active, that is it is drawn in the game.
        _highlight.SetActive(true);
    }

    private void OnMouseExit()
    {
        // Deactivate it again.
        _highlight.SetActive(false);
    }
}
