using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eat : MonoBehaviour {
    public void eatSound()
    {
        this.GetComponent<AudioSource>().Play();
    }

    public void eatParticle(Material crumbColor)
    {
        this.GetComponent<ParticleSystemRenderer>().material = crumbColor;
        this.GetComponent<ParticleSystem>().Emit(100);
    }
}