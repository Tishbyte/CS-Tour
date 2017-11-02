using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drinkExplode : MonoBehaviour {

    float v3Velocity;
    int counter = 0;

    // Update is called once per frame
    void Update () {
        v3Velocity = gameObject.GetComponent<Rigidbody>().velocity.magnitude;
        if (v3Velocity > 1)
        {
            Debug.Log(counter + "/" +v3Velocity);
            counter++;
            if (counter > 10)
            {
                Destroy(gameObject);
            }
        }
	}
}
