using Unity.VisualScripting;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public Action action;
    public int x, y, activated = 0;

    public void SetUp(int x, int y) 
    {
        this.x = x; this.y = y;
    }
}
