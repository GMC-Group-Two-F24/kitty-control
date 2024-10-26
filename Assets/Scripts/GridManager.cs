using UnityEngine;
using System.Collections.Generic;

public class GridManager : MonoBehaviour
{
  public GameObject gridCellPrefab; 
  public int rows = 5;
  public int cols = 5;

  void Start()
  {
    GenerateGrid();
  }

  void GenerateGrid()
  {
    for (int row = 0; row < rows; row++)
    {
      for (int col = 0; col < cols; col++)
      {
        Vector3 position = new Vector3(col, row, 0);
        Instantiate(gridCellPrefab, position, Quaternion.identity, transform);
      }
    }
  }
}
