using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour {

    public static AudioControl controller;

    AudioSource mainSource;
    public AudioClip[] audioClips;

    int currentClip = 0;

    private void Awake()
    {
        if (controller == null)
        {
            DontDestroyOnLoad(gameObject);
            controller = this;

            mainSource = GetComponent<AudioSource>();
            mainSource.clip = audioClips[currentClip];
            mainSource.Play();
        }
        else if (controller != this)
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (!mainSource.isPlaying)
        {
            GetNextClip();
        }
    }

    void GetNextClip ()
    {
        currentClip++;
        if (audioClips[currentClip] == null)
        {
            currentClip = 0;
        }
        mainSource.clip = audioClips[currentClip];
        mainSource.Play();
    }
}
