using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodEdible : MonoBehaviour {

    public GameObject nonEdible;
    public bool leftover;

    // Update is called once per frame
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (leftover == true)
            {
                this.gameObject.GetComponent<MeshFilter>().mesh = nonEdible.GetComponent<MeshFilter>().sharedMesh;
                this.gameObject.GetComponent<MeshRenderer>().materials = nonEdible.GetComponent<MeshRenderer>().sharedMaterials;
                this.gameObject.GetComponent<MeshCollider>().sharedMesh = nonEdible.GetComponent<MeshCollider>().sharedMesh;
                collision.gameObject.GetComponent<eat>().eatSound();
                collision.gameObject.GetComponent<eat>().eatParticle(this.GetComponent<MeshRenderer>().sharedMaterial);
                Destroy(this.gameObject.GetComponent<foodEdible>());
            }
            else
            {
                collision.gameObject.GetComponent<eat>().eatSound();
                collision.gameObject.GetComponent<eat>().eatParticle(this.GetComponent<MeshRenderer>().sharedMaterial);
                Destroy(this.gameObject);
            }
        }
    }
}
