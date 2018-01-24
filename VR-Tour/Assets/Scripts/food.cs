using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour {
	// Update is called once per frame
	void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
