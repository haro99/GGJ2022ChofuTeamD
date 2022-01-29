using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PiecePosition
{
    [SerializeField] public BoardPosition position;
    [SerializeField] public Piece pieceObj;
}
