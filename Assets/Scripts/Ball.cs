using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed; //ball's movement speed
    public Rigidbody2D ballRB; //reference to the rb2d component
    public Vector3 startPosition;
    

    // Start is called before the first frame update
    void Start()
    {
        ballRB = GetComponent<Rigidbody2D>();

        startPosition = transform.position;
        Launch();
        //determnes the initial direction of the ball
        int rnd = Random.Range(0, 2);
        switch (rnd)
        {
            case 1:
                ballRB.velocity = Vector2.right * speed;
                break;
            default:
                ballRB.velocity = Vector2.left * speed;
                break;
        }
    }

    public void Reset()
    {
        ballRB.velocity = Vector2.zero;
        transform.position = startPosition;
        Start();
    }
    private void Launch()
    {
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        ballRB.velocity = new Vector2(ballRB.velocity.x, speed * y);
    }

}
