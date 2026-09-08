using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Grid grid;
    public float maxPlayerHealth, tileAnimTime;
    float playerHealth;

    private void Start()
    {
        playerHealth = maxPlayerHealth;
    }

    public void StartTurn() 
    {
        StartCoroutine(DoTurn());
    }

    IEnumerator DoTurn() 
    {
        yield return 0;

        float roundDamage = 0;
        float roundBlock = 0;
        float roundMult = 1;

        Queue<Tile> queue = new Queue<Tile>();

        while (queue.Count > 0) 
        { 
            Tile cur = queue.Dequeue();

            //Do the cur selected action
            switch (cur.action.actionType)
            {
                case ActionType.ATTACK:
                    roundDamage += cur.action.val * roundMult;
                    break;
                case ActionType.DEFEND:
                    roundBlock += cur.action.val * roundMult;
                    break;
                case ActionType.MULT:
                    roundMult += cur.action.val;
                    break;
            }

            //check neighbours to activate and add to queue
            foreach (Vector2Int n in cur.action.neighbours) 
            {
                Tile next = grid.GetTile(cur.x + n.x, cur.y + n.y);
                if (next != null && next.action != null && next.activated < next.action.totalActivations) 
                { 
                    queue.Enqueue(next);
                    next.activated++;
                }
            }

            yield return new WaitForSeconds(tileAnimTime);
        }

        //Deal damage and gain block
    }

    public void EndTurn() { }
    public void CreateAction() 
    { 
        
    }
}
