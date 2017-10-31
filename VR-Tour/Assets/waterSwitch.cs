using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class waterSwitch : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<ParticleSystem>().Stop();
    }
    


    // Update is called once per frame
    public void toggleWater()
    {
        if (gameObject.GetComponent<ParticleSystem>().isPlaying == true)
        {
            gameObject.GetComponent<ParticleSystem>().Stop();
        }
        else
        {
            gameObject.GetComponent<ParticleSystem>().Play();
        }
    }
}
