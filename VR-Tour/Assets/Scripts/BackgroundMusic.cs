using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour {

    public AudioClip [] music;
    private int counter = 0;

    void Start()
    {
        this.GetComponent<AudioSource>().clip = music[counter];
        this.GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update () {
        if (this.GetComponent<AudioSource>().isPlaying == false)
        {
            if (counter == 2)
            {
                counter = 0;
            }
            else
            {
                counter++;
            }

            this.GetComponent<AudioSource>().clip = music[counter];
            this.GetComponent<AudioSource>().Play();
        }
	}
}
