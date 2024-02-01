using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed; //movement speed
    public float boundY; //y axis movement

    public Rigidbody2D playerPanel; //reference to the rb2d component

    public int wcPlayer; //identifies the player 1 and player 2

    // Start is called before the first frame update
    void Start()
    {
        playerPanel = GetComponent<Rigidbody2D>(); //automatically refereces the component of the object
    }

    // Update is called once per frame
    void Update()
    {
        var panelVelocity = playerPanel.velocity;

        //p1 controller
        if (wcPlayer == 1)
        {
            if (Input.GetKey(KeyCode.W)) // if w key is pressed
            {
                panelVelocity.y = speed; //moves the object in the y axis
            }
            else if (Input.GetKey(KeyCode.S)) // if s key is pressed
            {
                panelVelocity.y = -speed; //moves the object in the y axis
            }
            else
            {
                panelVelocity.y = 0; //this will stop the object from moving
            }
        }

        //p2 controller
        if (wcPlayer == 2)
        {
            if (Input.GetKey(KeyCode.UpArrow)) // if up arrow key is pressed
            {
                panelVelocity.y = speed; //moves the object in the y axis
            }
            else if (Input.GetKey(KeyCode.DownArrow)) // if down arrow key is pressed 
            {
                panelVelocity.y = -speed; //moves the object in the y axis
            }
            else
            {
                panelVelocity.y = 0; //this will stop the object from moving
            }
        }
        playerPanel.velocity = panelVelocity; // overwrites the vurrent velocity value

        //this is for the bounds limit
        var panelPos = transform.position;
        //this will check if the obejects goes beyond limit
        if (panelPos.y > boundY)
        {
            panelPos.y = boundY; //overwrites the current position if the current exceeds beyond limit
        }
        else if (panelPos.y < -boundY)
        {
            panelPos.y = -boundY; //overwrites the current position if the current exceeds beyong limit
        }
        transform.position = panelPos;
    }
}
