using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellController : MonoBehaviour
{
    public Cell cellPrefab;
    private List<List<Cell>> cellMatrix = new List<List<Cell>>();

    public float CellMatrixLength;
    public float CellMatrixHeight;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < CellMatrixLength; i++)
        {
            cellMatrix.Add(new List<Cell>());
            for (int j = 0; j < CellMatrixHeight; j++)
            {
                cellMatrix[i].Add(Instantiate(cellPrefab,new Vector3(-(CellMatrixLength / 4) + (i * 0.5f) + 0.25f,-(CellMatrixHeight / 4) + (j * 0.5f) + .25f,0),Quaternion.identity));
                cellMatrix[i][j].IsAlive = (i + j) % 2 == 0 ? false : true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var cellList in cellMatrix)
        {
            foreach (var cell in cellList)
                cell.SetMatColor();
        }
    }
}
