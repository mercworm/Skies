using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed;
    private Rigidbody2D rb2d;

    public GameObject midPoint;

    private void OnEnable()
    {
        //Checking when to reset the position.
        EventManager.StartListening("PlanetChange", ResetMovement);
    }

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    //Making the player move.
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rb2d.AddForce(movement * speed);
    }

    //Resetting the player's position on the center of the screen.
    public void ResetMovement ()
    {
        transform.position = midPoint.transform.position;
    }
}
