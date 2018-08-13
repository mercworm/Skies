using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed;
    private Rigidbody2D rb2d;

    public GameObject midPoint;

    private bool isPlaying = false;
    public AudioSource telescopeSound;

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

    //this stuff works, but it's not really ideal.
    //if I could just play it "while moving", that would be great.
    private void Update()
    {
        //add that bool so it doesn't start playing over and over
        if (rb2d.velocity.magnitude >= 0.2f)
        {
            telescopeSound.Play();
        }

     ////playing a sound while a button is held down
     //if (!isPlaying)
     //{
     //    if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
     //    {
     //        isPlaying = true;
     //        telescopeSound.Play();
     //    }
     //}
     //
     //if (isPlaying)
     //{
     //    if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
     //    {
     //        isPlaying = false;
     //        telescopeSound.Stop();
     //    }
     //}
    }


    //Resetting the player's position on the center of the screen.
    public void ResetMovement ()
    {
        transform.position = midPoint.transform.position;
    }
}
