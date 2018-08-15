using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LidSound : MonoBehaviour {

    public AudioSource lidSource;

    public AudioClip openSound;
    public AudioClip closeSound;

    public void PlayOne ()
    {
        lidSource.clip = openSound;
        lidSource.Play();
    }

    public void PlayTwo ()
    {
        lidSource.clip = closeSound;
        lidSource.Play();
    }
}
