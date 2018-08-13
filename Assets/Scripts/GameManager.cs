using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Image fadeScreen;

    private void Awake()
    {
        fadeScreen.CrossFadeAlpha(0, 0.01f, false);
    }

    //Update is called once per frame
    void Update () {
        //go back to the main menu.
		if (Input.GetKey(KeyCode.Escape))
        {
            StartCoroutine(Fading());
        }
	}

    public IEnumerator Fading()
    {
        fadeScreen.CrossFadeAlpha(1, 1f, false);
        yield return new WaitForSeconds(1);
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
}
