using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// 駒の基底クラス
public abstract class Piece : MonoBehaviour
{
    // その駒がそもそも移動可能なマス目の一覧
    // 例1: 右に一マス移動可能な場合はx: 1,y: 0と入力
    // 例2: 左に一マス移動可能な場合はx: -1,y: 0と入力
    // 例3: 上に一マス移動可能な場合はx: 0,y: 1と入力
    // 例4: 下に一マス移動可能な場合はx: 0,y: -1と入力 
    [SerializeField] protected List<BoardPosition> defaultMovableBoardPositions;

    public BoardPosition CurrentPosition { private set; get; }

    public void Initialize(int positionX, int positionY)
    {
        this.CurrentPosition = new BoardPosition(positionX, positionY);
    }
}
