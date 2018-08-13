using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Takes care of switching the skies.
public class SkySwitching : MonoBehaviour {

    public GameObject[] planets;
    public int currentSpace;

    public GameObject planetGroup;

    public Animator switchSkyAnim;
    public bool isSwitching = false;

    // Use this for initialization
    void Start ()
    {
        currentSpace = 0;
    }

    //switch the sky.
    public IEnumerator Switch()
    {
        switchSkyAnim.SetTrigger("Hide");
        yield return new WaitForSeconds(1); //until the animation is finished, so the player doesn't see the switch.
        EventManager.TriggerEvent("PlanetChange");

        for (int i = 0; i < planetGroup.transform.childCount; i++)
        {
            var child = planetGroup.transform.GetChild(i).gameObject;
            if (child != null)
                child.SetActive(false);
        }

        planets[currentSpace].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        isSwitching = false;
        StopCoroutine(Switch());
    }

    // Update is called once per frame
    void Update()
    {
        //check which button has been pressed.
        //change sky accordingly.
        if (!isSwitching)
        {
            if (Input.GetKey(KeyCode.Alpha1))
            {
                if (currentSpace != 1)
                {
                    isSwitching = true;
                    currentSpace = 1;
                    StartCoroutine(Switch());
                }
            }
            if (Input.GetKey(KeyCode.Alpha2))
            {
                if (currentSpace != 2)
                {
                    isSwitching = true;
                    currentSpace = 2;
                    StartCoroutine(Switch());
                }
            }
            if (Input.GetKey(KeyCode.Alpha3))
            {
                if (currentSpace != 3)
                {
                    isSwitching = true;
                    currentSpace = 3;
                    StartCoroutine(Switch());
                }
            }
            if (Input.GetKey(KeyCode.Alpha4))
            {
                if (currentSpace != 4)
                {
                    isSwitching = true;
                    currentSpace = 4;
                    StartCoroutine(Switch());
                }
            }
            if (Input.GetKey(KeyCode.Alpha5))
            {
                if (currentSpace != 5)
                {
                    isSwitching = true;
                    currentSpace = 5;
                    StartCoroutine(Switch());
                }
            }
            if (Input.GetKey(KeyCode.Alpha6))
            {
                if (currentSpace != 6)
                {
                    isSwitching = true;
                    currentSpace = 6;
                    StartCoroutine(Switch());
                }
            }
            if (Input.GetKey(KeyCode.Alpha7))
            {
                if (currentSpace != 7)
                {
                    isSwitching = true;
                    currentSpace = 7;
                    StartCoroutine(Switch());
                }
            }
            if (Input.GetKey(KeyCode.Alpha8))
            {
                if (currentSpace != 8)
                {
                    isSwitching = true;
                    currentSpace = 8;
                    StartCoroutine(Switch());
                }
            }
            if (Input.GetKey(KeyCode.Alpha9))
            {
                if (currentSpace != 9)
                {
                    isSwitching = true;
                    currentSpace = 9;
                    StartCoroutine(Switch());
                }
            }
        }
    }
}
