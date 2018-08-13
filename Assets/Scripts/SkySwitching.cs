using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkySwitching : MonoBehaviour {

    public GameObject[] planets;
    public int currentSpace;

    public GameObject planetGroup;

    // Use this for initialization
    void Start ()
    {
        currentSpace = 0;
    }

    public IEnumerator Switch()
    {
        //start whatever animation
        yield return new WaitForSeconds(0); //until the animation is finished, so the player doesn't see the switch.
        EventManager.TriggerEvent("PlanetChange");

        for (int i = 0; i < planetGroup.transform.childCount; i++)
        {
            var child = planetGroup.transform.GetChild(i).gameObject;
            if (child != null)
                child.SetActive(false);
        }


        planets[currentSpace].SetActive(true);
        //start whatever animation again, but the other way.
        StopCoroutine(Switch());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            if (currentSpace != 1)
            {
                currentSpace = 1;
                StartCoroutine(Switch());
            }
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            if (currentSpace != 2)
            {
                currentSpace = 2;
                StartCoroutine(Switch());
            }
        }
        else if (Input.GetKey(KeyCode.Alpha3))
        {
            if (currentSpace != 3)
            {
                currentSpace = 3;
                StartCoroutine(Switch());
            }
        }
        else if (Input.GetKey(KeyCode.Alpha4))
        {
            if (currentSpace != 4)
            {
                currentSpace = 4;
                StartCoroutine(Switch());
            }
        }
        else if (Input.GetKey(KeyCode.Alpha5))
        {
            if (currentSpace != 5)
            {
                currentSpace = 5;
                StartCoroutine(Switch());
            }
        }
        else if (Input.GetKey(KeyCode.Alpha6))
        {
            if (currentSpace != 6)
            {
                currentSpace = 6;
                StartCoroutine(Switch());
            }
        }
        else if (Input.GetKey(KeyCode.Alpha7))
        {
            if (currentSpace != 7)
            {
                currentSpace = 7;
                StartCoroutine(Switch());
            }
        }
        else if (Input.GetKey(KeyCode.Alpha8))
        {
            if (currentSpace != 8)
            {
                currentSpace = 8;
                StartCoroutine(Switch());
            }
        }
        else if (Input.GetKey(KeyCode.Alpha9))
        {
            if (currentSpace != 9)
            {
                currentSpace = 9;
                StartCoroutine(Switch());
            }
        }
        else return;
    }
}
