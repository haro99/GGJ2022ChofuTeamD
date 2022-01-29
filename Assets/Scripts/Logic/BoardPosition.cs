using System;
using UnityEngine;

[Serializable]
public class BoardPosition
{
    [SerializeField] public int x;
    [SerializeField] public int y;

    public BoardPosition()
    {

    }

    public BoardPosition(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

}
