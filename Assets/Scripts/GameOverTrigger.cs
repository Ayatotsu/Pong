using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverTrigger : MonoBehaviour
{
    public GameManager gameManager;

    public Text txtMessage;
    public GameObject Ball;
    public GameObject paddlePlayer1;
    public GameObject ButtonReset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D actor)
    {
        if (actor.gameObject.CompareTag("Ball"))
        {
            txtMessage.text = "Game Over!";
            Ball.gameObject.SetActive(false);
            paddlePlayer1.gameObject.SetActive(false);
            ButtonReset.gameObject.SetActive(true);
        }
    }
}
