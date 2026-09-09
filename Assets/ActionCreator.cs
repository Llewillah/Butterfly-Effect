using UnityEngine;

public class ActionCreator : MonoBehaviour
{
    public Vector2Int[] possibleDirections;
    public int[] damageRolls, defenseRolls, totalDirs;
    public float[] multRolls, dirChances;
    public GameObject action;
    public void CreateAction(int quality) 
    { 
        Instantiate(action);
        Action ac = action.GetComponent<Action>();

        int randInt = Random.Range(0, 3);
        int randDirChance = Random.Range(0, 1);

        if (randInt == 0) 
        {
            ac.actionType = ActionType.ATTACK;
            ac.val = damageRolls[quality];
        }
        else if (randInt == 1) 
        {
            ac.actionType = ActionType.DEFEND;
            ac.val = defenseRolls[quality];
        }
        else if (randInt == 2) 
        {
            ac.actionType = ActionType.MULT;
            ac.val = multRolls[quality];
        }

        if (randDirChance < dirChances[quality]) 
        {
            for (int i = 0; i < totalDirs.Length; i++) 
            {
                int rand = Random.Range(0, possibleDirections.Length);
                ac.neighbours.Add(possibleDirections[rand]);
            }
        }
    }
}
