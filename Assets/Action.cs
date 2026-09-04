using UnityEngine;

public enum ActionType
{
    ACTION, MULT, ADD, SUBTRACT
}

[CreateAssetMenu(fileName = "Action", menuName = "Scriptable Objects/Action")]
public class Action : ScriptableObject
{
    public int size;
    public bool[] neighbours;


    public ActionType actionType;
    public float val;
}
