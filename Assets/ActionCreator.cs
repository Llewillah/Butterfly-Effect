using UnityEngine;

public class ActionCreator : MonoBehaviour
{
    public Vector2Int[] possibleDirections;
    public int[] damageRolls, defenseRolls, multRolls;
    public GameObject action;
    public void CreateAction() 
    { 
        Instantiate(action);
        Action ac = action.GetComponent<Action>();

        int randInt = Random.Range(0, 3);

        if (randInt == 0) { }
        else if (randInt == 1) { }
        else if (randInt == 2) { }
    }
}
