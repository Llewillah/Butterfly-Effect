using UnityEngine;

public enum ActionType
{
    ATTACK, DEFEND, MULT
}

public class Action: MonoBehaviour
{
    public int totalActivations;
    public Vector2Int[] neighbours;
    public ActionType actionType;
    public float val;

    public void CreateAction() 
    { 
        
    }
}
