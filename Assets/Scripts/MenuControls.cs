using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Takes care of what the player can do from the main menu.
public class MenuControls : MonoBehaviour {

    public Image fadeScreen;

    private void Awake()
    {
        fadeScreen.CrossFadeAlpha(0, 1f, false);
    }

    // Update is called once per frame
    void Update () {
        //Start the game.
		if (Input.GetKey(KeyCode.Space))
        {
            StartCoroutine(Fading());
        }
        //Quit the game.
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
	}

    public IEnumerator Fading ()
    {
        fadeScreen.CrossFadeAlpha(1, 1f, false);
        yield return new WaitForSeconds(1);
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
    }
}
