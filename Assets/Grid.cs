using UnityEngine;

public class GridNode 
{ 
    int x, y;
    IActionable action;

    public GridNode(int x, int y, IActionable action)
    {
        this.x = x;
        this.y = y;
        this.action = action;
    }
}


public class Grid 
{
    GridNode[,] grid;
    Vector2 originPos;
    int width, height;
    float cellSize;

    public Grid(int width, int height, float cellSize, Vector2 originPos) 
    { 
        this.width = width;
        this.height = height;
        this.cellSize = cellSize;
        this.originPos = originPos;

        grid = new GridNode[width, height];

        for (int x = 0; x < width; x++) 
        {
            for (int y = 0; y < height; y++) 
            { 
                //grid[x,y] = new GridNode(x,y, NEW THING HERE);
            }
        }
    }

    public void DrawGrid()
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                Vector2 pos = GetWorldPos(i, j);

                //Draws GridTiles
                Debug.DrawLine(pos, pos + Vector2.up * cellSize);
                Debug.DrawLine(pos, pos + Vector2.right * cellSize);
            }
        }

        Debug.DrawLine(GetWorldPos(width, 0), GetWorldPos(width, height));
        Debug.DrawLine(GetWorldPos(0, height), GetWorldPos(width, height));
    }

    void GetGridPos(Vector2 pos, out int x, out int y)
    {
        pos -= originPos;

        x = (int)(pos.x / cellSize);
        y = (int)(pos.y / cellSize);
    }

    Vector2 GetWorldPos(int x, int y)
    {
        return new Vector2(x * cellSize, y * cellSize) + originPos;
    }
}
