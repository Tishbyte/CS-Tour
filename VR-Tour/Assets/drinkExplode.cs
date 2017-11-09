using VRTK;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drinkExplode : MonoBehaviour {

    float v3Velocity;
    int counter = 0;
    void Start()
    {
        gameObject.GetComponent<ParticleSystem>().Stop();
        //make sure the object has the VRTK script attached... 
        if (GetComponent<VRTK_InteractableObject>() == null)
        {
            Debug.LogError("Error.");
            return;
        }
        //subscribe to the event.  NOTE: the "ObectGrabbed"  this is the procedure to invoke if this objectis grabbed.. 
        GetComponent<VRTK_InteractableObject>().InteractableObjectUsed += new InteractableObjectEventHandler(explode);
    }

    private void explode(object sender, InteractableObjectEventArgs e)
    {
        counter++;
        StartCoroutine(spray(counter));
    }
    IEnumerator spray(int counter)
    {
        if (counter > 5)
        {
            gameObject.GetComponent<ParticleSystem>().Play();
            yield return new WaitForSeconds(counter);
            Destroy(gameObject);
        }
        else
        {
            gameObject.GetComponent<ParticleSystem>().Play();
            yield return new WaitForSeconds(counter * .1f);
            gameObject.GetComponent<ParticleSystem>().Stop();
        }
    }
}
