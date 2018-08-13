using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour {

    public static AudioControl controller;

    AudioSource mainSource;

    //either a group, or a single audio file i have edited.

    private void Awake()
    {
        if (controller == null)
        {
            DontDestroyOnLoad(gameObject);
            controller = this;
        }
        else if (controller != this)
        {
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start () {
        mainSource = GetComponent<AudioSource>();
	}

    //make a void or something that takes care of audio switching (if I need it) or looping and stuff.
    //this might just be a script to make sure that the music is always playing.
}
