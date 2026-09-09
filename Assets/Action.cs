using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public enum ActionType
{
    ATTACK, DEFEND, MULT
}

public class Action: MonoBehaviour
{
    public int totalActivations;
    public List<Vector2Int> neighbours;
    public ActionType actionType;
    public float val;

    public void CreateAction() 
    { 
        
    }

    private void OnMouseDrag()
    {
        transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Mouse.current.position.value);
    }
}
