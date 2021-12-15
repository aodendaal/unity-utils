using UnityEngine;

public class Grid
{
    private int height;
    private int width;
    private float cellSize;

    private int[,] gridArray;

    public Grid(int width, int height, float cellSize)
    {
        this.width = width;
        this.height = height;
        this.cellSize = cellSize;

        gridArray = new int[width, height];
    }

    private Vector3 GetWorldPosition(int x, int y)
    {
        return new Vector3(x * cellSize, y * cellSize);
    }

    public void SetValue(int x, int y, int value)
    {
        gridArray[x, y] = value;
    }
}