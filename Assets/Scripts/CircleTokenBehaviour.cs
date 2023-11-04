using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleTokenBehaviour : TokenBehaviour
{
    public EColor color;

   
    public override void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerBaseBehaviour playerBase = collision.GetComponent<PlayerBaseBehaviour>();
        if (playerBase.color == color)
        {   
            gameManager.score++;
        }
        else
        {  
            gameManager.GameIsRunning = false;
        }
        Destroy(this.gameObject);
    }
}
