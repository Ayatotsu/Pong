using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    public GameManager gameManager; //this is reference to GameManager class/script that the user can access its variables
    

    public int whatWall; //this identifies w/c wall the ball hits

    [Header("GameOver")]
    public GameObject PlayerWins;
    public GameObject GameOver;
    public GameObject ButtonReset;
    public GameObject ButtonMainMenu;
    public GameObject Ball;
    public GameObject paddlePlayer1;
    public GameObject paddlePlayer2;
    public Text txtMessage;

    public void OnCollisionEnter2D(Collision2D actor)
    {
        //increments the score depending on w/c wall the ball hits
        if (actor.gameObject.CompareTag("Ball"))
        {
            switch (whatWall)
            {
                case 1:
                    gameManager.p1Score += 1;
                    gameManager.GetComponent<GameManager>().ResetPosition();
                    paddlePlayer1.GetComponent<PlayerController>().Reset();
                    paddlePlayer2.GetComponent<PlayerController>().Reset();
                    break;
            
                case 2:
                    gameManager.p2Score += 1;
                    gameManager.GetComponent<GameManager>().ResetPosition();
                    paddlePlayer1.GetComponent<PlayerController>().Reset();
                    paddlePlayer2.GetComponent<PlayerController>().Reset();
                    break;

            }
            
            switch (whatWall)
            { 
                case 1:
                    if (gameManager.p1Score == 10)
                    {
                        txtMessage.text = ("Player 1 Wins");
                        GameOver.gameObject.SetActive(true);
                        PlayerWins.gameObject.SetActive(true);
                        Ball.gameObject.SetActive(false);
                        paddlePlayer1.gameObject.SetActive(false);
                        paddlePlayer2.gameObject.SetActive(false);
                        ButtonReset.gameObject.SetActive(true);
                        ButtonMainMenu.gameObject.SetActive(true);

                    }
                    break;

                case 2:
                    if (gameManager.p2Score == 10)
                    {
                        txtMessage.text = ("Player 2 Wins");
                        GameOver.gameObject.SetActive(true);
                        PlayerWins.gameObject.SetActive(true);
                        Ball.gameObject.SetActive(false);
                        paddlePlayer1.gameObject.SetActive(false);
                        paddlePlayer2.gameObject.SetActive(false);
                        ButtonReset.gameObject.SetActive(true);
                        ButtonMainMenu.gameObject.SetActive(true);
                    }
                    break;


            }
        }
    }
}
