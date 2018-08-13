using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if (!isSwitching)
        {
            if (Input.GetKey(KeyCode.Alpha1))
            {
                isSwitching = true;
                if (currentSpace != 1)
                {
                    currentSpace = 1;
                    StartCoroutine(Switch());
                }
            }
            else if (Input.GetKey(KeyCode.Alpha2))
            {
                isSwitching = true;
                if (currentSpace != 2)
                {
                    currentSpace = 2;
                    StartCoroutine(Switch());
                }
            }
            else if (Input.GetKey(KeyCode.Alpha3))
            {
                isSwitching = true;
                if (currentSpace != 3)
                {
                    currentSpace = 3;
                    StartCoroutine(Switch());
                }
            }
            else if (Input.GetKey(KeyCode.Alpha4))
            {
                isSwitching = true;
                if (currentSpace != 4)
                {
                    currentSpace = 4;
                    StartCoroutine(Switch());
                }
            }
            else if (Input.GetKey(KeyCode.Alpha5))
            {
                isSwitching = true;
                if (currentSpace != 5)
                {
                    currentSpace = 5;
                    StartCoroutine(Switch());
                }
            }
            else if (Input.GetKey(KeyCode.Alpha6))
            {
                isSwitching = true;
                if (currentSpace != 6)
                {
                    currentSpace = 6;
                    StartCoroutine(Switch());
                }
            }
            else if (Input.GetKey(KeyCode.Alpha7))
            {
                isSwitching = true;
                if (currentSpace != 7)
                {
                    currentSpace = 7;
                    StartCoroutine(Switch());
                }
            }
            else if (Input.GetKey(KeyCode.Alpha8))
            {
                isSwitching = true;
                if (currentSpace != 8)
                {
                    currentSpace = 8;
                    StartCoroutine(Switch());
                }
            }
            else if (Input.GetKey(KeyCode.Alpha9))
            {
                isSwitching = true;
                if (currentSpace != 9)
                {
                    currentSpace = 9;
                    StartCoroutine(Switch());
                }
            }
            else return;
        }
    }
}
