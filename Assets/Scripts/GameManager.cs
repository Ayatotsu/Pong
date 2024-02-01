using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public string levelName; //this is used for tracking or identifying what game mode or level the player is

    //variables that holds the score value
    public int p1Score;
    public int p2Score;

    //this variables will display the score on screen
    //these variables are reference to the ui elements in the game
    public Text txtP1Score;
    public Text txtP2Score;

    //this is used for ricochet
    public bool isThereAnyBricks;
    public Text txtMessage;

    // Update is called once per frame
    void Update()
    {
        //conditions that check what game mode the player is
        //this is for pong level
        if (levelName == "Pong")
        {
            txtP1Score.text = p1Score.ToString(); //displays the value on screen by converting int variables to string
            txtP2Score.text = p2Score.ToString();
        }

        //this is for ricochet level
        if (levelName == "Ricochet")
        {
            if (isThereAnyBricks)
            {
                txtMessage.text = "You Win";
            }
        }

    }
}
