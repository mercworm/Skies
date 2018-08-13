using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControls : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Space))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
	}
}
