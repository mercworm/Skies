using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed;
    public float soundStopPoint, soundStartPoint;
    private Rigidbody2D rb2d;

    public GameObject midPoint;

    private bool isPlaying = false;
    public AudioSource telescopeSound;

    private bool canMove = false;

    private void OnEnable()
    {
        //Checking when to reset the position.
        EventManager.StartListening("PlanetChange", ResetMovement);
        //Checking when the player's movement needs switching.
        EventManager.StartListening("PlayerMovementToggle", MoveToggle);
    }

    private void OnDisable()
    {
        EventManager.StopListening("PlanetChange", ResetMovement);
        EventManager.StopListening("PlayerMovementToggle", MoveToggle);
    }

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    //Making the player move.
    void FixedUpdate()
    {
        if (canMove)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector2 movement = new Vector2(moveHorizontal, moveVertical);

            rb2d.AddForce(movement * speed);
        }
    }

    //triggering every time the planets switch, so the player can't move while the animation is playing.
    public void MoveToggle ()
    {
        if (canMove) canMove = false;
        else canMove = true;
    }

    //this stuff works, but it's not really ideal.
    //if I could just play it "while moving", that would be great.
    private void Update()
    {
        //add that bool so it doesn't start playing over and over
        if (isPlaying == false)
        {
            if (rb2d.velocity.magnitude >= soundStartPoint)
            {
                isPlaying = true;
                telescopeSound.Play();
            }
        }
        if (rb2d.velocity.magnitude < soundStopPoint)
        {
            isPlaying = false;
            telescopeSound.Stop();
        }
    }

    //Resetting the player's position on the center of the screen.
    public void ResetMovement ()
    {
        transform.position = midPoint.transform.position;
    }
}
