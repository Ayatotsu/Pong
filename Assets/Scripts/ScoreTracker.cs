using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTracker : MonoBehaviour
{
    public GameManager gameManager; //this is reference to GameManager class/script that the user can access its variables

    public int whatWall; //this identifies w/c wall the ball hits

    public void OnCollisionEnter2D(Collision2D actor)
    {
        //increments the score depending on w/c wall the ball hits
        if (actor.gameObject.CompareTag("Ball"))
        {
            switch (whatWall)
            {
                case 1:
                    gameManager.p1Score += 1;
                    break;
                case 2:
                    gameManager.p2Score += 1;
                    break;
            }
        }
    }
}
