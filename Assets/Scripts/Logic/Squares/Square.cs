using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 普通のマス目
public class Square : MonoBehaviour
{
    public BoardPosition boardPosition { private set; get; }

    public void Initialize(int positionX, int positionY)
    {
        this.boardPosition = new BoardPosition(positionX, positionY);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
