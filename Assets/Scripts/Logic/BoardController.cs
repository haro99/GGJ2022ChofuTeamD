using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoardController : MonoBehaviour
{
    // 盤面の横幅のマス数(とりあえず8マス)
    [SerializeField] private int boardWidth;
    // 盤面の縦幅のマス数(とりあえず10マス)
    [SerializeField] private int boardHeight;

    [SerializeField] private List<BoardPosition> territoryPositions;

    [SerializeField] private GridLayoutGroup boardGridLayoutGroup;
    [SerializeField] private GameObject gridSquareObject;

    private List<Square> gridSquares = new List<Square>();

    private void GenerateBoardGrid()
    {
        for(int i = 0;i < boardHeight; ++i)
        {
            for (int j = 0; j < boardWidth; ++j)
            {
                Square gridSquare = ComponentUtil.InstantiateTo<Square>(boardGridLayoutGroup.gameObject, gridSquareObject);
                gridSquare.Initialize(i, j);
                gridSquares.Add(gridSquare);
            }
        }
    }

    private void Awake()
    {
        GenerateBoardGrid();
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
