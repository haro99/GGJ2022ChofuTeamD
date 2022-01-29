using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridCell : MonoBehaviour
{
    public int X { private set; get; }
    public int Y { private set; get; }

    public void Initialize(int positionX, int positionY)
    {
        this.X = positionX;
        this.Y = positionY;
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
