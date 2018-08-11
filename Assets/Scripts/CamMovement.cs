using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour {

    Vector3 camPos;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update () {
        camPos.x = Input.mousePosition.x;
        camPos.y = Input.mousePosition.y;

        transform.position = camPos;
	}
}
