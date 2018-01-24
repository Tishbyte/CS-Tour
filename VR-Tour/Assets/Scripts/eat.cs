using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eat : MonoBehaviour {

    public AudioClip sandwich, chip, cheeto;

    public void eatSound()
    {
        int random = Random.Range(0, 3);

        if (random == 0)
        {
            this.GetComponent<AudioSource>().clip = sandwich;
        }
        else if (random == 1)
        {
            this.GetComponent<AudioSource>().clip = chip;
        }
        else
        {
            this.GetComponent<AudioSource>().clip = cheeto;
        }

        this.GetComponent<AudioSource>().Play();
    }

    public void eatParticle(Material crumbColor)
    {
        this.GetComponent<ParticleSystemRenderer>().material = crumbColor;
        this.GetComponent<ParticleSystem>().Emit(100);
    }
}