using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodEdible : MonoBehaviour {

    public MeshFilter nonEdible;
    public bool leftover;

    // Update is called once per frame
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (leftover == true)
            {
                this.gameObject.GetComponent<MeshFilter>().mesh = nonEdible.sharedMesh;
                this.gameObject.GetComponent<MeshCollider>().sharedMesh = nonEdible.sharedMesh;
                this.gameObject.GetComponent<foodEdible>().enabled = false;
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }
}
