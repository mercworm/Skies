using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed;
    private Rigidbody2D rb2d;

    public GameObject midPoint;

    private void OnEnable()
    {
        EventManager.StartListening("ResetPlayerMovement", ResetMovement);
    }

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rb2d.AddForce(movement * speed);
    }

    public void ResetMovement ()
    {
        transform.position = Vector3.MoveTowards(transform.position, midPoint.transform.position, speed);
    }
}
